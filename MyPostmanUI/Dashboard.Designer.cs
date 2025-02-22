namespace MyPostmanUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FormHeader = new Label();
            apiLabel = new Label();
            sendButton = new Button();
            apiText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            httpVerbSelector = new ComboBox();
            resultTab = new TabPage();
            resultsText = new TextBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            bodyText = new TextBox();
            statusStrip.SuspendLayout();
            resultTab.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            SuspendLayout();
            // 
            // FormHeader
            // 
            FormHeader.AutoSize = true;
            FormHeader.BackColor = Color.Transparent;
            FormHeader.Font = new Font("HP Simplified Hans", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormHeader.Location = new Point(118, 69);
            FormHeader.Margin = new Padding(2, 0, 2, 0);
            FormHeader.Name = "FormHeader";
            FormHeader.Size = new Size(176, 34);
            FormHeader.TabIndex = 0;
            FormHeader.Text = "MyPostman";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.BackColor = Color.Transparent;
            apiLabel.Font = new Font("Segoe UI", 15F);
            apiLabel.Location = new Point(102, 154);
            apiLabel.Margin = new Padding(2, 0, 2, 0);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(57, 35);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.Transparent;
            sendButton.Location = new Point(774, 156);
            sendButton.Margin = new Padding(2);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(74, 35);
            sendButton.TabIndex = 2;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += sendButton_click;
            // 
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(317, 156);
            apiText.Margin = new Padding(2);
            apiText.Name = "apiText";
            apiText.Size = new Size(453, 34);
            apiText.TabIndex = 3;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 605);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 9, 0);
            statusStrip.Size = new Size(1145, 38);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 14F);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(78, 32);
            systemStatus.Text = "Ready";
            // 
            // httpVerbSelector
            // 
            httpVerbSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelector.FormattingEnabled = true;
            httpVerbSelector.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            httpVerbSelector.Location = new Point(179, 156);
            httpVerbSelector.Name = "httpVerbSelector";
            httpVerbSelector.Size = new Size(115, 36);
            httpVerbSelector.TabIndex = 7;
            // 
            // resultTab
            // 
            resultTab.Controls.Add(resultsText);
            resultTab.Location = new Point(4, 29);
            resultTab.Name = "resultTab";
            resultTab.Padding = new Padding(3);
            resultTab.Size = new Size(799, 337);
            resultTab.TabIndex = 1;
            resultTab.Text = "Result";
            resultTab.UseVisualStyleBackColor = true;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Dock = DockStyle.Fill;
            resultsText.Location = new Point(3, 3);
            resultsText.Margin = new Padding(2);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(793, 331);
            resultsText.TabIndex = 5;
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(resultTab);
            callData.Location = new Point(114, 198);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(807, 370);
            callData.TabIndex = 8;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(bodyText);
            bodyTab.Location = new Point(4, 37);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(799, 329);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            bodyTab.UseWaitCursor = true;
            // 
            // bodyText
            // 
            bodyText.BackColor = Color.White;
            bodyText.BorderStyle = BorderStyle.FixedSingle;
            bodyText.Dock = DockStyle.Fill;
            bodyText.Location = new Point(3, 3);
            bodyText.Margin = new Padding(2);
            bodyText.Multiline = true;
            bodyText.Name = "bodyText";
            bodyText.ScrollBars = ScrollBars.Both;
            bodyText.Size = new Size(793, 323);
            bodyText.TabIndex = 6;
            bodyText.UseWaitCursor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1145, 643);
            Controls.Add(callData);
            Controls.Add(httpVerbSelector);
            Controls.Add(statusStrip);
            Controls.Add(apiText);
            Controls.Add(sendButton);
            Controls.Add(apiLabel);
            Controls.Add(FormHeader);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            Text = "Postman Clone by Saba";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            resultTab.ResumeLayout(false);
            resultTab.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormHeader;
        private Label apiLabel;
        private Button sendButton;
        private TextBox apiText;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpVerbSelector;
        private TabPage resultTab;
        private TextBox resultsText;
        private TabControl callData;
        private TabPage bodyTab;
        private TextBox bodyText;
    }
}
