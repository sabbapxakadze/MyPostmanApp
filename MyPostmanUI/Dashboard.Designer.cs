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
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // FormHeader
            // 
            FormHeader.AutoSize = true;
            FormHeader.Font = new Font("Segoe UI", 18F);
            FormHeader.Location = new Point(119, 53);
            FormHeader.Margin = new Padding(2, 0, 2, 0);
            FormHeader.Name = "FormHeader";
            FormHeader.Size = new Size(175, 41);
            FormHeader.TabIndex = 0;
            FormHeader.Text = "MyPostman";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
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
            sendButton.Location = new Point(647, 156);
            sendButton.Margin = new Padding(2);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(74, 35);
            sendButton.TabIndex = 2;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_click;
            // 
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(177, 155);
            apiText.Margin = new Padding(2);
            apiText.Name = "apiText";
            apiText.Size = new Size(453, 34);
            apiText.TabIndex = 3;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Location = new Point(150, 293);
            resultsText.Margin = new Padding(2);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(698, 206);
            resultsText.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 614);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 9, 0);
            statusStrip.Size = new Size(1187, 38);
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
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 18F);
            resultsLabel.Location = new Point(99, 250);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(105, 41);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Result:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 652);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormHeader;
        private Label apiLabel;
        private Button sendButton;
        private TextBox apiText;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
