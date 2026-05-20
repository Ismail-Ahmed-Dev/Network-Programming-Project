namespace Client
{
    partial class Form1
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
            btnSelect = new Button();
            btnSend = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(82, 109);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(238, 52);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(429, 109);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(238, 52);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(175, 259);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(492, 39);
            lblStatus.TabIndex = 3;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(btnSend);
            Controls.Add(btnSelect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelect;
        private Button btnSend;
        private Label lblStatus;
    }
}
