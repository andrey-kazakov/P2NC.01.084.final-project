using System;
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
        public Form1()
        {
            InitializeComponent();

            requestMethodComboBox.Text = "GET";
            requestProtocolComboBox.Text = "http://";
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

            return request;
        }
    }
}
