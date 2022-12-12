using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
        public Form1()
        {
            InitializeComponent();

            requestMethodComboBox.Text = "GET";
            requestProtocolComboBox.Text = "http://";
        }

        private void requestMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            requestPayloadTextBox.Enabled = isRequestPayloadAllowed();
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

        private void requestHostTextBox_TextChanged(object sender, EventArgs e)
        {
            requestHeaders["Host"] = requestHostTextBox.Text;
            updateRequestHeadersForm();
        }

        private void requestAddHeaderButton_Click(object sender, EventArgs e)
        {
            requestHeaders[requestHeaderTextBox.Text] = requestHeaderValueTextBox.Text;

            requestHeaderTextBox.Text = "";
            requestHeaderValueTextBox.Text = "";

            updateRequestHeadersForm();
        }

        private void updateRequestHeadersForm()
        {
            requestHeadersListBox.Items.Clear();

            foreach (var header in requestHeaders)
            {
                requestHeadersListBox.Items.Add($"{header.Key}: {header.Value}");
            }
        }

        private void requestRemoveHeaderButton_Click(object sender, EventArgs e)
        {
            requestRemoveHeaderButton.Enabled = false;
            string header = requestHeadersListBox.SelectedItem.ToString().Split(':')[0];
            requestHeaders.Remove(header);
            updateRequestHeadersForm();
        }

        private void requestHeadersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            requestRemoveHeaderButton.Enabled = requestHeadersListBox.SelectedItem != null;
        }
        private void requestRunButton_Click(object sender, EventArgs e)
        {
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

            var request = buildHttpRequestMessage();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            HttpResponseMessage response = await client.SendAsync(request);
            timer.Stop();

            populateResponseForm(response, timer);

            response.Dispose();
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
                $"{requestProtocolComboBox.Text}{requestHostTextBox.Text}{requestPathTextBox.Text}"
            );

            if (isRequestPayloadAllowed())
            {
                request.Content = new StringContent(requestPayloadTextBox.Text);
            }

            foreach (var header in requestHeaders)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            return request;
        }
    }
}
