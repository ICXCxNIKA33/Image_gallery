namespace Image_Gallery.Forms
{
    partial class DebugForm
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
            lblImageCount = new Label();
            lstImages = new ListBox();
            btnGenerateTestData = new Button();
            btnClearImages = new Button();
            btnClose = new Button();
            btnRefresh = new Button();
            lblListImages = new Label();
            SuspendLayout();
            // 
            // lblImageCount
            // 
            lblImageCount.AutoSize = true;
            lblImageCount.Location = new Point(74, 33);
            lblImageCount.Name = "lblImageCount";
            lblImageCount.Size = new Size(97, 20);
            lblImageCount.TabIndex = 0;
            lblImageCount.Text = "Image Count:";
            // 
            // lstImages
            // 
            lstImages.FormattingEnabled = true;
            lstImages.Location = new Point(74, 104);
            lstImages.Name = "lstImages";
            lstImages.Size = new Size(161, 264);
            lstImages.TabIndex = 1;
            // 
            // btnGenerateTestData
            // 
            btnGenerateTestData.Location = new Point(74, 393);
            btnGenerateTestData.Name = "btnGenerateTestData";
            btnGenerateTestData.Size = new Size(161, 84);
            btnGenerateTestData.TabIndex = 2;
            btnGenerateTestData.Text = "Generate Test Data";
            btnGenerateTestData.UseVisualStyleBackColor = true;
            btnGenerateTestData.Click += btnGenerateTestData_Click;
            // 
            // btnClearImages
            // 
            btnClearImages.Location = new Point(74, 500);
            btnClearImages.Name = "btnClearImages";
            btnClearImages.Size = new Size(161, 84);
            btnClearImages.TabIndex = 3;
            btnClearImages.Text = "Clear Images";
            btnClearImages.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(74, 711);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(161, 84);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(74, 605);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(161, 84);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblListImages
            // 
            lblListImages.AutoSize = true;
            lblListImages.Location = new Point(83, 94);
            lblListImages.Name = "lblListImages";
            lblListImages.Size = new Size(101, 20);
            lblListImages.TabIndex = 6;
            lblListImages.Text = "List of Images";
            // 
            // DebugForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 812);
            Controls.Add(lblListImages);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnClearImages);
            Controls.Add(btnGenerateTestData);
            Controls.Add(lstImages);
            Controls.Add(lblImageCount);
            Name = "DebugForm";
            Text = "DebugForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImageCount;
        private ListBox lstImages;
        private Button btnGenerateTestData;
        private Button btnClearImages;
        private Button btnClose;
        private Button btnRefresh;
        private Label lblListImages;
    }
}