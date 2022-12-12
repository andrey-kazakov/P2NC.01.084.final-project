namespace final_project_AndreiKazakov
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.requestGroupBox = new System.Windows.Forms.GroupBox();
            this.responseGroupBox = new System.Windows.Forms.GroupBox();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.responseHeadersListBox = new System.Windows.Forms.ListBox();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.requestMethodComboBox = new System.Windows.Forms.ComboBox();
            this.requestProtocolComboBox = new System.Windows.Forms.ComboBox();
            this.requestHostTextBox = new System.Windows.Forms.TextBox();
            this.requestPathTextBox = new System.Windows.Forms.TextBox();
            this.requestMethodLabel = new System.Windows.Forms.Label();
            this.requestProtocolLabel = new System.Windows.Forms.Label();
            this.requestHostLabel = new System.Windows.Forms.Label();
            this.requestPathLabel = new System.Windows.Forms.Label();
            this.requestRunButton = new System.Windows.Forms.Button();
            this.requestHeadersListBox = new System.Windows.Forms.ListBox();
            this.requestHeaderLabel = new System.Windows.Forms.Label();
            this.requestHeaderTextBox = new System.Windows.Forms.TextBox();
            this.requestHeaderValueLabel = new System.Windows.Forms.Label();
            this.requestHeaderValueTextBox = new System.Windows.Forms.TextBox();
            this.requestAddHeaderButton = new System.Windows.Forms.Button();
            this.requestRemoveHeaderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.requestPayloadTextBox = new System.Windows.Forms.TextBox();
            this.requestGroupBox.SuspendLayout();
            this.responseGroupBox.SuspendLayout();
            this.requestPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestGroupBox
            // 
            this.requestGroupBox.Controls.Add(this.requestPayloadTextBox);
            this.requestGroupBox.Controls.Add(this.label1);
            this.requestGroupBox.Controls.Add(this.requestRemoveHeaderButton);
            this.requestGroupBox.Controls.Add(this.requestAddHeaderButton);
            this.requestGroupBox.Controls.Add(this.requestHeaderValueTextBox);
            this.requestGroupBox.Controls.Add(this.requestHeaderValueLabel);
            this.requestGroupBox.Controls.Add(this.requestHeaderTextBox);
            this.requestGroupBox.Controls.Add(this.requestHeaderLabel);
            this.requestGroupBox.Controls.Add(this.requestHeadersListBox);
            this.requestGroupBox.Controls.Add(this.requestRunButton);
            this.requestGroupBox.Controls.Add(this.requestPathLabel);
            this.requestGroupBox.Controls.Add(this.requestHostLabel);
            this.requestGroupBox.Controls.Add(this.requestProtocolLabel);
            this.requestGroupBox.Controls.Add(this.requestMethodLabel);
            this.requestGroupBox.Controls.Add(this.requestPathTextBox);
            this.requestGroupBox.Controls.Add(this.requestHostTextBox);
            this.requestGroupBox.Controls.Add(this.requestProtocolComboBox);
            this.requestGroupBox.Controls.Add(this.requestMethodComboBox);
            this.requestGroupBox.Location = new System.Drawing.Point(4, 4);
            this.requestGroupBox.Name = "requestGroupBox";
            this.requestGroupBox.Size = new System.Drawing.Size(769, 307);
            this.requestGroupBox.TabIndex = 0;
            this.requestGroupBox.TabStop = false;
            this.requestGroupBox.Text = "Request";
            // 
            // responseGroupBox
            // 
            this.responseGroupBox.Controls.Add(this.responseTextBox);
            this.responseGroupBox.Controls.Add(this.responseHeadersListBox);
            this.responseGroupBox.Location = new System.Drawing.Point(4, 317);
            this.responseGroupBox.Name = "responseGroupBox";
            this.responseGroupBox.Size = new System.Drawing.Size(769, 305);
            this.responseGroupBox.TabIndex = 1;
            this.responseGroupBox.TabStop = false;
            this.responseGroupBox.Text = "Response";
            // 
            // requestPanel
            // 
            this.requestPanel.Controls.Add(this.responseGroupBox);
            this.requestPanel.Controls.Add(this.requestGroupBox);
            this.requestPanel.Location = new System.Drawing.Point(12, 12);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(776, 625);
            this.requestPanel.TabIndex = 3;
            // 
            // responseHeadersListBox
            // 
            this.responseHeadersListBox.FormattingEnabled = true;
            this.responseHeadersListBox.Location = new System.Drawing.Point(7, 20);
            this.responseHeadersListBox.Name = "responseHeadersListBox";
            this.responseHeadersListBox.Size = new System.Drawing.Size(756, 95);
            this.responseHeadersListBox.TabIndex = 0;
            // 
            // responseTextBox
            // 
            this.responseTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseTextBox.Location = new System.Drawing.Point(7, 122);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ReadOnly = true;
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responseTextBox.Size = new System.Drawing.Size(756, 177);
            this.responseTextBox.TabIndex = 1;
            // 
            // requestMethodComboBox
            // 
            this.requestMethodComboBox.DisplayMember = "0";
            this.requestMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestMethodComboBox.FormattingEnabled = true;
            this.requestMethodComboBox.Items.AddRange(new object[] {
            "GET",
            "DELETE",
            "HEAD",
            "OPTIONS",
            "PATCH",
            "POST",
            "PUT",
            "TRACE"});
            this.requestMethodComboBox.Location = new System.Drawing.Point(7, 32);
            this.requestMethodComboBox.Name = "requestMethodComboBox";
            this.requestMethodComboBox.Size = new System.Drawing.Size(79, 21);
            this.requestMethodComboBox.TabIndex = 0;
            this.requestMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.requestMethodComboBox_SelectedIndexChanged);
            // 
            // requestProtocolComboBox
            // 
            this.requestProtocolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestProtocolComboBox.FormattingEnabled = true;
            this.requestProtocolComboBox.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.requestProtocolComboBox.Location = new System.Drawing.Point(92, 32);
            this.requestProtocolComboBox.Name = "requestProtocolComboBox";
            this.requestProtocolComboBox.Size = new System.Drawing.Size(75, 21);
            this.requestProtocolComboBox.TabIndex = 1;
            // 
            // requestHostTextBox
            // 
            this.requestHostTextBox.Location = new System.Drawing.Point(174, 33);
            this.requestHostTextBox.Name = "requestHostTextBox";
            this.requestHostTextBox.Size = new System.Drawing.Size(147, 20);
            this.requestHostTextBox.TabIndex = 2;
            this.requestHostTextBox.TextChanged += new System.EventHandler(this.requestHostTextBox_TextChanged);
            // 
            // requestPathTextBox
            // 
            this.requestPathTextBox.Location = new System.Drawing.Point(328, 32);
            this.requestPathTextBox.Name = "requestPathTextBox";
            this.requestPathTextBox.Size = new System.Drawing.Size(354, 20);
            this.requestPathTextBox.TabIndex = 3;
            this.requestPathTextBox.Text = "/";
            // 
            // requestMethodLabel
            // 
            this.requestMethodLabel.AutoSize = true;
            this.requestMethodLabel.Location = new System.Drawing.Point(7, 19);
            this.requestMethodLabel.Name = "requestMethodLabel";
            this.requestMethodLabel.Size = new System.Drawing.Size(43, 13);
            this.requestMethodLabel.TabIndex = 4;
            this.requestMethodLabel.Text = "Method";
            // 
            // requestProtocolLabel
            // 
            this.requestProtocolLabel.AutoSize = true;
            this.requestProtocolLabel.Location = new System.Drawing.Point(92, 19);
            this.requestProtocolLabel.Name = "requestProtocolLabel";
            this.requestProtocolLabel.Size = new System.Drawing.Size(46, 13);
            this.requestProtocolLabel.TabIndex = 5;
            this.requestProtocolLabel.Text = "Protocol";
            // 
            // requestHostLabel
            // 
            this.requestHostLabel.AutoSize = true;
            this.requestHostLabel.Location = new System.Drawing.Point(174, 20);
            this.requestHostLabel.Name = "requestHostLabel";
            this.requestHostLabel.Size = new System.Drawing.Size(29, 13);
            this.requestHostLabel.TabIndex = 6;
            this.requestHostLabel.Text = "Host";
            // 
            // requestPathLabel
            // 
            this.requestPathLabel.AutoSize = true;
            this.requestPathLabel.Location = new System.Drawing.Point(328, 19);
            this.requestPathLabel.Name = "requestPathLabel";
            this.requestPathLabel.Size = new System.Drawing.Size(29, 13);
            this.requestPathLabel.TabIndex = 7;
            this.requestPathLabel.Text = "Path";
            // 
            // requestRunButton
            // 
            this.requestRunButton.Location = new System.Drawing.Point(688, 29);
            this.requestRunButton.Name = "requestRunButton";
            this.requestRunButton.Size = new System.Drawing.Size(75, 23);
            this.requestRunButton.TabIndex = 8;
            this.requestRunButton.Text = "Run";
            this.requestRunButton.UseVisualStyleBackColor = true;
            this.requestRunButton.Click += new System.EventHandler(this.requestRunButton_Click);
            // 
            // requestHeadersListBox
            // 
            this.requestHeadersListBox.FormattingEnabled = true;
            this.requestHeadersListBox.Location = new System.Drawing.Point(7, 60);
            this.requestHeadersListBox.Name = "requestHeadersListBox";
            this.requestHeadersListBox.Size = new System.Drawing.Size(756, 95);
            this.requestHeadersListBox.TabIndex = 9;
            this.requestHeadersListBox.SelectedIndexChanged += new System.EventHandler(this.requestHeadersListBox_SelectedIndexChanged);
            // 
            // requestHeaderLabel
            // 
            this.requestHeaderLabel.AutoSize = true;
            this.requestHeaderLabel.Location = new System.Drawing.Point(7, 162);
            this.requestHeaderLabel.Name = "requestHeaderLabel";
            this.requestHeaderLabel.Size = new System.Drawing.Size(42, 13);
            this.requestHeaderLabel.TabIndex = 10;
            this.requestHeaderLabel.Text = "Header";
            // 
            // requestHeaderTextBox
            // 
            this.requestHeaderTextBox.Location = new System.Drawing.Point(56, 162);
            this.requestHeaderTextBox.Name = "requestHeaderTextBox";
            this.requestHeaderTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestHeaderTextBox.TabIndex = 11;
            // 
            // requestHeaderValueLabel
            // 
            this.requestHeaderValueLabel.AutoSize = true;
            this.requestHeaderValueLabel.Location = new System.Drawing.Point(163, 162);
            this.requestHeaderValueLabel.Name = "requestHeaderValueLabel";
            this.requestHeaderValueLabel.Size = new System.Drawing.Size(34, 13);
            this.requestHeaderValueLabel.TabIndex = 12;
            this.requestHeaderValueLabel.Text = "Value";
            // 
            // requestHeaderValueTextBox
            // 
            this.requestHeaderValueTextBox.Location = new System.Drawing.Point(204, 161);
            this.requestHeaderValueTextBox.Name = "requestHeaderValueTextBox";
            this.requestHeaderValueTextBox.Size = new System.Drawing.Size(381, 20);
            this.requestHeaderValueTextBox.TabIndex = 13;
            // 
            // requestAddHeaderButton
            // 
            this.requestAddHeaderButton.Location = new System.Drawing.Point(591, 159);
            this.requestAddHeaderButton.Name = "requestAddHeaderButton";
            this.requestAddHeaderButton.Size = new System.Drawing.Size(75, 23);
            this.requestAddHeaderButton.TabIndex = 14;
            this.requestAddHeaderButton.Text = "Add Header";
            this.requestAddHeaderButton.UseVisualStyleBackColor = true;
            this.requestAddHeaderButton.Click += new System.EventHandler(this.requestAddHeaderButton_Click);
            // 
            // requestRemoveHeaderButton
            // 
            this.requestRemoveHeaderButton.Enabled = false;
            this.requestRemoveHeaderButton.Location = new System.Drawing.Point(673, 157);
            this.requestRemoveHeaderButton.Name = "requestRemoveHeaderButton";
            this.requestRemoveHeaderButton.Size = new System.Drawing.Size(75, 23);
            this.requestRemoveHeaderButton.TabIndex = 15;
            this.requestRemoveHeaderButton.Text = "Remove";
            this.requestRemoveHeaderButton.UseVisualStyleBackColor = true;
            this.requestRemoveHeaderButton.Click += new System.EventHandler(this.requestRemoveHeaderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Payload (only for PATCH, POST, PUT methods)";
            // 
            // requestPayloadTextBox
            // 
            this.requestPayloadTextBox.Enabled = false;
            this.requestPayloadTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestPayloadTextBox.Location = new System.Drawing.Point(7, 207);
            this.requestPayloadTextBox.Multiline = true;
            this.requestPayloadTextBox.Name = "requestPayloadTextBox";
            this.requestPayloadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.requestPayloadTextBox.Size = new System.Drawing.Size(756, 100);
            this.requestPayloadTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.requestPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "API Tester: final project (Andrei Kazakov)";
            this.requestGroupBox.ResumeLayout(false);
            this.requestGroupBox.PerformLayout();
            this.responseGroupBox.ResumeLayout(false);
            this.responseGroupBox.PerformLayout();
            this.requestPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox requestGroupBox;
        private System.Windows.Forms.GroupBox responseGroupBox;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.ListBox responseHeadersListBox;
        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.ComboBox requestProtocolComboBox;
        private System.Windows.Forms.ComboBox requestMethodComboBox;
        private System.Windows.Forms.Button requestRemoveHeaderButton;
        private System.Windows.Forms.Button requestAddHeaderButton;
        private System.Windows.Forms.TextBox requestHeaderValueTextBox;
        private System.Windows.Forms.Label requestHeaderValueLabel;
        private System.Windows.Forms.TextBox requestHeaderTextBox;
        private System.Windows.Forms.Label requestHeaderLabel;
        private System.Windows.Forms.ListBox requestHeadersListBox;
        private System.Windows.Forms.Button requestRunButton;
        private System.Windows.Forms.Label requestPathLabel;
        private System.Windows.Forms.Label requestHostLabel;
        private System.Windows.Forms.Label requestProtocolLabel;
        private System.Windows.Forms.Label requestMethodLabel;
        private System.Windows.Forms.TextBox requestPathTextBox;
        private System.Windows.Forms.TextBox requestHostTextBox;
        private System.Windows.Forms.TextBox requestPayloadTextBox;
        private System.Windows.Forms.Label label1;
    }
}

