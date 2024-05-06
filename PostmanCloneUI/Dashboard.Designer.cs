namespace PostmanCloneUI
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
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            resultsWindow = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 128);
            formHeader.Location = new Point(33, 9);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(277, 54);
            formHeader.TabIndex = 0;
            formHeader.Text = "PostmanClone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 128);
            apiLabel.Location = new Point(33, 78);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(64, 38);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiText
            // 
            apiText.Location = new Point(103, 85);
            apiText.Name = "apiText";
            apiText.Size = new Size(567, 31);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(676, 85);
            callApi.Name = "callApi";
            callApi.Size = new Size(112, 34);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // resultsWindow
            // 
            resultsWindow.BackColor = Color.White;
            resultsWindow.BorderStyle = BorderStyle.FixedSingle;
            resultsWindow.Location = new Point(43, 195);
            resultsWindow.Multiline = true;
            resultsWindow.Name = "resultsWindow";
            resultsWindow.ReadOnly = true;
            resultsWindow.ScrollBars = ScrollBars.Both;
            resultsWindow.Size = new Size(745, 202);
            resultsWindow.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 442);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(833, 37);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 128);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(73, 30);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 128);
            resultsLabel.Location = new Point(33, 139);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(111, 38);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(833, 479);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsWindow);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Name = "Dashboard";
            Text = "PostmanClone";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private TextBox resultsWindow;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
