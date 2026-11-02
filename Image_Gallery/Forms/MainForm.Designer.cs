namespace Image_Gallery
{
    partial class MainForm
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
            txtSearchByTag = new TextBox();
            lblSearchByTag = new Label();
            btnSearch = new Button();
            menuStrip = new MenuStrip();
            uploadImageToolStripMenuItem = new ToolStripMenuItem();
            uploadImageToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lbxTagManagement = new ListBox();
            lblTagManager = new Label();
            flpMainGallery = new FlowLayoutPanel();
            IGpictureBox1 = new PictureBox();
            picImagePreview = new PictureBox();
            lblPreview = new Label();
            gbxMetadata = new GroupBox();
            txtFilePath = new TextBox();
            lbxMDTags = new ListBox();
            txtDateAdded = new TextBox();
            txtFileName = new TextBox();
            lblFilePath = new Label();
            lblMDTags = new Label();
            lblDateAdded = new Label();
            lblFileName = new Label();
            lblStatusMessage = new Label();
            ofdUploadImage = new OpenFileDialog();
            menuStrip.SuspendLayout();
            flpMainGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IGpictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagePreview).BeginInit();
            gbxMetadata.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchByTag
            // 
            txtSearchByTag.Location = new Point(12, 75);
            txtSearchByTag.Name = "txtSearchByTag";
            txtSearchByTag.Size = new Size(135, 27);
            txtSearchByTag.TabIndex = 2;
            // 
            // lblSearchByTag
            // 
            lblSearchByTag.AutoSize = true;
            lblSearchByTag.Location = new Point(12, 52);
            lblSearchByTag.Name = "lblSearchByTag";
            lblSearchByTag.Size = new Size(102, 20);
            lblSearchByTag.TabIndex = 3;
            lblSearchByTag.Text = "Search by tag:";
            lblSearchByTag.Click += label1_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(67, 27);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { uploadImageToolStripMenuItem, uploadImageToolStripMenuItem1, exitToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1627, 28);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "menuStrip2";
            menuStrip.ItemClicked += menuStrip2_ItemClicked;
            // 
            // uploadImageToolStripMenuItem
            // 
            uploadImageToolStripMenuItem.Name = "uploadImageToolStripMenuItem";
            uploadImageToolStripMenuItem.Size = new Size(46, 24);
            uploadImageToolStripMenuItem.Text = "File";
            uploadImageToolStripMenuItem.Click += uploadImageToolStripMenuItem_Click;
            // 
            // uploadImageToolStripMenuItem1
            // 
            uploadImageToolStripMenuItem1.Name = "uploadImageToolStripMenuItem1";
            uploadImageToolStripMenuItem1.Size = new Size(118, 24);
            uploadImageToolStripMenuItem1.Text = "Upload Image";
            uploadImageToolStripMenuItem1.Click += uploadImageToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // lbxTagManagement
            // 
            lbxTagManagement.FormattingEnabled = true;
            lbxTagManagement.Location = new Point(12, 151);
            lbxTagManagement.Name = "lbxTagManagement";
            lbxTagManagement.Size = new Size(150, 624);
            lbxTagManagement.TabIndex = 7;
            // 
            // lblTagManager
            // 
            lblTagManager.AutoSize = true;
            lblTagManager.Location = new Point(22, 141);
            lblTagManager.Name = "lblTagManager";
            lblTagManager.Size = new Size(41, 20);
            lblTagManager.TabIndex = 8;
            lblTagManager.Text = "Tags:";
            // 
            // flpMainGallery
            // 
            flpMainGallery.Controls.Add(IGpictureBox1);
            flpMainGallery.Location = new Point(201, 52);
            flpMainGallery.Name = "flpMainGallery";
            flpMainGallery.Size = new Size(1107, 723);
            flpMainGallery.TabIndex = 9;
            // 
            // IGpictureBox1
            // 
            IGpictureBox1.BorderStyle = BorderStyle.FixedSingle;
            IGpictureBox1.Location = new Point(3, 3);
            IGpictureBox1.Name = "IGpictureBox1";
            IGpictureBox1.Size = new Size(165, 124);
            IGpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            IGpictureBox1.TabIndex = 0;
            IGpictureBox1.TabStop = false;
            IGpictureBox1.Click += IGpictureBox1_Click;
            // 
            // picImagePreview
            // 
            picImagePreview.Location = new Point(1341, 75);
            picImagePreview.Name = "picImagePreview";
            picImagePreview.Size = new Size(249, 228);
            picImagePreview.TabIndex = 10;
            picImagePreview.TabStop = false;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.Location = new Point(1410, 52);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(106, 20);
            lblPreview.TabIndex = 11;
            lblPreview.Text = "Image Preview";
            // 
            // gbxMetadata
            // 
            gbxMetadata.BackColor = SystemColors.Control;
            gbxMetadata.Controls.Add(txtFilePath);
            gbxMetadata.Controls.Add(lbxMDTags);
            gbxMetadata.Controls.Add(txtDateAdded);
            gbxMetadata.Controls.Add(txtFileName);
            gbxMetadata.Controls.Add(lblFilePath);
            gbxMetadata.Controls.Add(lblMDTags);
            gbxMetadata.Controls.Add(lblDateAdded);
            gbxMetadata.Controls.Add(lblFileName);
            gbxMetadata.Location = new Point(1330, 309);
            gbxMetadata.Name = "gbxMetadata";
            gbxMetadata.Size = new Size(274, 466);
            gbxMetadata.TabIndex = 12;
            gbxMetadata.TabStop = false;
            gbxMetadata.Text = "Image Metadata";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(6, 410);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(226, 27);
            txtFilePath.TabIndex = 7;
            // 
            // lbxMDTags
            // 
            lbxMDTags.FormattingEnabled = true;
            lbxMDTags.Location = new Point(11, 130);
            lbxMDTags.Name = "lbxMDTags";
            lbxMDTags.Size = new Size(253, 244);
            lbxMDTags.TabIndex = 6;
            // 
            // txtDateAdded
            // 
            txtDateAdded.Location = new Point(105, 70);
            txtDateAdded.Name = "txtDateAdded";
            txtDateAdded.ReadOnly = true;
            txtDateAdded.Size = new Size(127, 27);
            txtDateAdded.TabIndex = 5;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(89, 35);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(143, 27);
            txtFileName.TabIndex = 4;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(6, 387);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(69, 20);
            lblFilePath.TabIndex = 3;
            lblFilePath.Text = "File path:";
            // 
            // lblMDTags
            // 
            lblMDTags.AutoSize = true;
            lblMDTags.Location = new Point(6, 106);
            lblMDTags.Name = "lblMDTags";
            lblMDTags.Size = new Size(41, 20);
            lblMDTags.TabIndex = 2;
            lblMDTags.Text = "Tags:";
            lblMDTags.Click += label1_Click_1;
            // 
            // lblDateAdded
            // 
            lblDateAdded.AutoSize = true;
            lblDateAdded.Location = new Point(6, 73);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(93, 20);
            lblDateAdded.TabIndex = 1;
            lblDateAdded.Text = "Date Added:";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(6, 38);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(79, 20);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "File Name:";
            lblFileName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.Location = new Point(48, 792);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(114, 20);
            lblStatusMessage.TabIndex = 13;
            lblStatusMessage.Text = "Status Message:";
            // 
            // ofdUploadImage
            // 
            ofdUploadImage.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 821);
            Controls.Add(lblStatusMessage);
            Controls.Add(gbxMetadata);
            Controls.Add(lblPreview);
            Controls.Add(picImagePreview);
            Controls.Add(flpMainGallery);
            Controls.Add(lblTagManager);
            Controls.Add(lbxTagManagement);
            Controls.Add(btnSearch);
            Controls.Add(lblSearchByTag);
            Controls.Add(txtSearchByTag);
            Controls.Add(menuStrip);
            Name = "MainForm";
            Text = "Image Gallery";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            flpMainGallery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IGpictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagePreview).EndInit();
            gbxMetadata.ResumeLayout(false);
            gbxMetadata.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUploadImage;
        private TextBox txtSearchByTag;
        private Label lblSearchByTag;
        private Button btnSearch;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem uploadImageToolStripMenuItem;
        private ToolStripMenuItem uploadImageToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ListBox lbxTagManagement;
        private Label lblTagManager;
        private FlowLayoutPanel flpMainGallery;
        private PictureBox picImagePreview;
        private Label lblPreview;
        private GroupBox gbxMetadata;
        private Label lblMDTags;
        private Label lblDateAdded;
        private Label lblFileName;
        private TextBox txtFilePath;
        private ListBox lbxMDTags;
        private TextBox txtDateAdded;
        private TextBox txtFileName;
        private Label lblFilePath;
        private Label lblStatusMessage;
        private OpenFileDialog ofdUploadImage;
        private PictureBox IGpictureBox1;
    }
}
