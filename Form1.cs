using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project_AndreiKazakov
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> requestHeaders = new Dictionary<string, string>();
        const string CONTENT_LENGTH_HEADER = "Content-Length";
        public Form1()
        {
            InitializeComponent();

            requestMethodComboBox.Text = "GET";
            requestProtocolComboBox.Text = "http://";
        }

        private void requestMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            requestPayloadTextBox.Enabled = isRequestPayloadAllowed();

            if (isRequestPayloadAllowed())
            {
                requestHeaders[CONTENT_LENGTH_HEADER] = requestPayloadTextBox.Text.Length.ToString();
            }
            else
            {
                requestHeaders.Remove(CONTENT_LENGTH_HEADER);
            }
            updateRequestHeadersForm();
        }

        private bool isRequestPayloadAllowed()
        {
            switch (requestMethodComboBox.Text)
            {
                case "POST":
                case "PATCH":
                case "PUT":
                    return true;
                default:
                    return false;
            }
        }

        private void requestPayloadTextBox_TextChanged(object sender, EventArgs e)
        {
            requestHeaders[CONTENT_LENGTH_HEADER] = requestPayloadTextBox.Text.Length.ToString();
            updateRequestHeadersForm();
        }

        private void requestHostTextBox_TextChanged(object sender, EventArgs e)
        {
            requestHeaders["Host"] = requestHostTextBox.Text;
            updateRequestHeadersForm();
        }

        private void requestAddHeaderButton_Click(object sender, EventArgs e)
        {
            if (getRequestHeaderName().Length < 1 || requestHeaderValueTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Header name and value shouldn't be empty", "Invalid header", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            requestHeaders[getRequestHeaderName()] = requestHeaderValueTextBox.Text.Trim();

            requestHeaderTextBox.Text = "";
            requestHeaderValueTextBox.Text = "";

            updateRequestHeadersForm();
        }

        private string getRequestHeaderName()
        {
            var parts = requestHeaderTextBox
                .Text
                .ToLower()
                .Split('-')
                .ToList()
                .ConvertAll<String>(part => part.Trim())
                .ToArray()
                .Where(part => part.Length >= 1);

            return string
                .Join("-", parts.ToList().ConvertAll<String>(part => part[0].ToString().ToUpper() + part.Substring(1)).ToArray());
        }

        private void updateRequestHeadersForm()
        {
            requestRemoveHeaderButton.Enabled = false;
            requestHeadersListBox.Items.Clear();

            foreach (var header in requestHeaders)
            {
                requestHeadersListBox.Items.Add($"{header.Key}: {header.Value}");
            }
        }

        private void requestRemoveHeaderButton_Click(object sender, EventArgs e)
        {
            if (requestHeadersListBox.SelectedItem != null)
            {
                string header = requestHeadersListBox.SelectedItem.ToString().Split(':')[0];
                requestHeaders.Remove(header);
                updateRequestHeadersForm();
            }
        }

        private void requestHeadersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            requestRemoveHeaderButton.Enabled = requestHeadersListBox.SelectedItem != null;
        }

        private void requestRunButton_Click(object sender, EventArgs e)
        {
            if (requestHostTextBox.Text.Trim().Length < 1 || requestPathTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Host and path shouldn't be empty", "Invalid request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var header in requestHeaders)
            {
                if (header.Key.StartsWith("Content-") && !isRequestPayloadAllowed())
                {
                    MessageBox.Show("Content-* headers are allowed only for POST, PATCH, PUT methods", "Invalid request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Cursor = Cursors.WaitCursor;
            requestRunButton.Enabled = false;
            runRequest();

            Cursor = Cursors.Default;
            requestRunButton.Enabled = true;
        }

        private async void runRequest()
        {
            HttpClient client = new HttpClient();

            clearResponseForm();

            Stopwatch timer = new Stopwatch();
            timer.Start();

            try
            {
                var request = buildHttpRequestMessage();

                HttpResponseMessage response = await client.SendAsync(request);
                timer.Stop();

                populateResponseForm(response, timer);

                response.Dispose();
            }
            catch (Exception e)
            {
                timer.Stop();

                responseGroupBox.Text = $"Response: Failed, took {timer.ElapsedMilliseconds} ms";
                responseTextBox.Text = e.ToString();
            }
        }

        private void clearResponseForm()
        {
            responseGroupBox.Text = "Response: Pending";
            responseTextBox.Text = "";
            responseHeadersListBox.Items.Clear();
        }

        private async void populateResponseForm(HttpResponseMessage response, Stopwatch timer)
        {
            responseGroupBox.Text = $"Response: {((int)response.StatusCode)} {response.ReasonPhrase}, took {timer.ElapsedMilliseconds} ms";

            foreach (var header in response.Headers)
            {
                responseHeadersListBox.Items.Add($"{header.Key}: {string.Join(",", header.Value)}");
            }

            foreach (var header in response.Content.Headers)
            {
                responseHeadersListBox.Items.Add($"{header.Key}: {string.Join(",", header.Value)}");
            }

            responseTextBox.Text = await response.Content.ReadAsStringAsync();
        }

        private HttpRequestMessage buildHttpRequestMessage()
        {
            HttpRequestMessage request = new HttpRequestMessage(
                new HttpMethod(requestMethodComboBox.Text),
                $"{requestProtocolComboBox.Text}{requestHostTextBox.Text.Trim()}{requestPathTextBox.Text.Trim()}"
            );

            if (isRequestPayloadAllowed())
            {
                request.Content = new StringContent(requestPayloadTextBox.Text);
            }

            foreach (var header in requestHeaders)
            {
                if (header.Key.StartsWith("Content-"))
                {
                    request.Content.Headers.Remove(header.Key);
                    request.Content.Headers.Add(header.Key, header.Value);
                }
                else
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            return request;
        }
    }
}
