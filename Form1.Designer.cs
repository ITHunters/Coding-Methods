namespace CleanCodeMethods
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
            btn_Notification = new Button();
            SuspendLayout();
            // 
            // btn_Notification
            // 
            btn_Notification.Location = new Point(118, 267);
            btn_Notification.Name = "btn_Notification";
            btn_Notification.Size = new Size(140, 35);
            btn_Notification.TabIndex = 0;
            btn_Notification.Text = "Send Notification";
            btn_Notification.UseVisualStyleBackColor = true;
            btn_Notification.Click += btn_Notification_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 314);
            Controls.Add(btn_Notification);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Notification;
    }
}
