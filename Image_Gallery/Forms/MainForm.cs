using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using Image_Gallery.Forms;
using ImageGallery.Models;
// represents metadata for a gallery image



namespace Image_Gallery
{

    public partial class MainForm : Form
    {
        // list for holding ImageData objects
        private List<ImageData> imageGallery = new List<ImageData>();
        private ImageData selectedImage = null;

        // selected thumbnail field
        private PictureBox? selectedThumbnail;


        // constructor, Initialize component and apply properties to main flow layout panel
        public MainForm()
        {
            InitializeComponent();

            flpMainGallery.AutoScroll = true;
            flpMainGallery.WrapContents = true;
            flpMainGallery.FlowDirection = FlowDirection.LeftToRight;
        }



        // function to refresh gallery
        private void RefreshGallery()
        {
            flpMainGallery.Controls.Clear();

            foreach (ImageData image in imageGallery)
            {
                PictureBox thumbnail = new PictureBox();

                // read files for image thumbnail
                using (FileStream fs = new FileStream(
                    image.FilePath,
                    FileMode.Open,
                    FileAccess.Read))
                {
                    thumbnail.Image = Image.FromStream(fs);
                }

                // set thumbnail properties
                thumbnail.Width = 150;
                thumbnail.Height = 120;
                thumbnail.SizeMode = PictureBoxSizeMode.Zoom;
                thumbnail.BorderStyle = BorderStyle.FixedSingle;
                thumbnail.Margin = new Padding(5);

                // store ImageData object
                thumbnail.Tag = image;

                // register click event
                thumbnail.Click += Thumbnail_Click;

                flpMainGallery.Controls.Add(thumbnail);

                // updates image preview
                if (selectedImage != null) 
                {
                    UpdatePreview(selectedImage);
                }
            }
        }

        // for updating preview
        private void UpdatePreview(ImageData image)
        {
            picImagePreview.Image = Image.FromFile(image.FilePath);

            //show metadata in preview column

            txtFileName.Text = image.FileName;
            txtDateAdded.Text = image.DateAdded.ToString("MM/dd/yyyy HH:mm");
            txtFilePath.Text = image.FilePath;
        }

        // thumbnail click event handler
        private void Thumbnail_Click(object? sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender!;

            if (selectedThumbnail != null)
            {
                selectedThumbnail.BackColor = Color.Transparent;
            }

            pb.BackColor = Color.LightBlue;

            selectedThumbnail = pb;

            ImageData image = (ImageData)pb.Tag!;

            selectedImage = image;

            picImagePreview.Image = Image.FromFile(image.FilePath);

            //show metadata in preview column

            txtFileName.Text = image.FileName;
            txtDateAdded.Text = image.DateAdded.ToString("MM/dd/yyyy HH:mm");
            txtFilePath.Text = image.FilePath;


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tbTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void uploadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // function for uploading images
        private void uploadImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // filter file types
            ofdUploadOrReplaceImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";

            // open file dialog title
            ofdUploadOrReplaceImage.Title = "Select an Image";

            // validate openFileDialog result
            if (ofdUploadOrReplaceImage.ShowDialog() == DialogResult.OK)
            {
                // get file path
                string filepath = ofdUploadOrReplaceImage.FileName;

                // try catch for validating file type
                try
                {
                    // validate file extension 
                    string extension = Path.GetExtension(filepath).ToLower();

                    // if block for invalid file extension
                    if (extension != ".jpg" &&
                        extension != ".jpeg" &&
                        extension != ".png" &&
                        extension != ".bmp" &&
                        extension != ".gif")
                    {
                        // throw invalid extension exception
                        throw new InvalidDataException("Selected file is not a supported image type!");
                    }

                    // extract image from file path
                    Image img = Image.FromFile(filepath);

                    // collect metadata with filepath data and Path and Datetime functions
                    ImageData imageInfo = new ImageData
                    {
                        FileName = Path.GetFileName(filepath),
                        FilePath = filepath,
                        DateAdded = DateTime.Now,
                    };

                    //create fileinfo object
                    FileInfo file = new FileInfo(filepath);

                    // assign file size and info metadata
                    imageInfo.fileSize = (int)file.Length;
                    imageInfo.fileExtension = file.Extension;

                    // finally, add created image object to the list
                    imageGallery.Add(imageInfo);

                    // refresh gallery
                    RefreshGallery();

                }
                // catch exceptions
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading image:\n" + ex.Message,
                        "Upload Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }


            }

        }

        private void IGpictureBox1_Click(object sender, EventArgs e)
        {

        }

        // keyboard shortcut foir debug menu
        protected override bool ProcessCmdKey(
            ref Message msg,
            Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.D))
            {
                new DebugForm(imageGallery).ShowDialog();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picImagePreview_Click(object sender, EventArgs e)
        {

        }

        // function for deleting images
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (selectedImage == null)
            {
                // if image is not selected already
                MessageBox.Show(
                    "Please select an image first.",
                    "No Image Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // yes/no dialog confirming user wants to delete an image
            DialogResult result = MessageBox.Show(
                $"Delete '{selectedImage.FileName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // remove from gallery list
            imageGallery.Remove(selectedImage);

            // clear preview
            picImagePreview.Image = null;

            txtFileName.Clear();
            txtDateAdded.Clear();
            txtFilePath.Clear();

            // reset selection
            selectedImage = null;
            selectedThumbnail = null;

            // rebuild gallery
            RefreshGallery();

            // show succesfull deletion of item
            MessageBox.Show(
                "Image deleted successfully.",
                "Delete Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // function for replacing images
        private void replaceImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (selectedImage == null)
            {
                MessageBox.Show(
                    "Please select an image first.",
                    "No Image Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // filter file types
            ofdUploadOrReplaceImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";

            // open file
            ofdUploadOrReplaceImage.Title = "Select an Image";

            if (ofdUploadOrReplaceImage.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofdUploadOrReplaceImage.FileName;

                try
                {
                    // validate file extension 
                    string extension = Path.GetExtension(filepath).ToLower();
                
                    if (extension != ".jpg" &&
                        extension != ".jpeg" &&
                        extension != ".png" &&
                        extension != ".bmp" &&
                        extension != ".gif")
                    {
                        throw new InvalidDataException("Selected file is not a supported image type!");
                    }

                    // extract image from file path
                    Image img = Image.FromFile(filepath);

                    // update metadata
                    selectedImage.FileName = Path.GetFileName(filepath);
                    selectedImage.FilePath = filepath;
                    selectedImage.DateAdded = DateTime.Now;

                    // for fileInfo metadata
                    FileInfo file = new FileInfo(filepath);
                    selectedImage.fileSize = (int)file.Length;
                    selectedImage.fileExtension = file.Extension;

                    // refresh gallery
                    RefreshGallery();
                }
                // catch exceptions
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error replacing image:\n" + ex.Message,
                        "Upload Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }
    }
}
