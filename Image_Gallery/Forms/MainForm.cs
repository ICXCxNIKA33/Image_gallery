using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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

            // disables the add tag button by default
            btnAddTags.Enabled = false;
        }



        // function to refresh gallery
        private void RefreshGallery()
        {
            // clears gallery flow panel controls for rebuilding
            selectedThumbnail = null;
            flpMainGallery.Controls.Clear();

            // builds new thumbnails with pictureboxes 
            foreach (ImageData image in imageGallery)
            {
                try
                {
                    PictureBox thumbnail = new PictureBox();

                    thumbnail.Image = Image.FromFile(image.FilePath);

                    // set thumbnail properties
                    thumbnail.Width = 150;
                    thumbnail.Height = 120;
                    thumbnail.SizeMode = PictureBoxSizeMode.Zoom;
                    thumbnail.BorderStyle = BorderStyle.FixedSingle;
                    thumbnail.Margin = new Padding(5);

                    // store ImageData object
                    thumbnail.Tag = image;

                    // put highlight colors back on selected thumbnail
                    if (image == selectedImage)
                    {
                        thumbnail.BackColor = Color.LightBlue;
                        selectedThumbnail = thumbnail;

                        // updates image preview for selected image
                        UpdatePreview(image);
                    }

                    // register click event
                    thumbnail.Click += Thumbnail_Click;

                    flpMainGallery.Controls.Add(thumbnail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Failed to load:\n{image.FilePath}\n\n{ex}",
                        "Thumbnail Error");
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

            // enables the add tag button
            btnAddTags.Enabled = true;

            //show metadata and image in preview column
            UpdatePreview(image);
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
            ofdUploadOrReplaceImage.Title = "Select an Image For Uploading";

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

                    // add newest image as the selected image
                    selectedImage = imageInfo;

                    // enable add tag button
                    btnAddTags.Enabled = true;

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

        // keyboard shortcut for debug menu
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

            // disable add tags button
            btnAddTags.Enabled = false;

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
            ofdUploadOrReplaceImage.Title = "Select an Image For Replacing";

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

        private void lbxTagManagement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            // get string from user and add it to list box (autocapitalize first character, check for duplicates,
            // do not accept empty string or strings with nothing but white space
            // tag entry only enabled if image thumbnail is selected

            // check that an image is selected
            if (selectedImage == null)
            {
                MessageBox.Show("Please select an image for adding tags.",
                                "No image selected!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // get tag from textbox
                string tag = txtAddTags.Text.Trim();

                // confirm tag contains characters
                if (!ValidateTags(tag))
                {
                    MessageBox.Show(
                        "Please enter a valid tag.",
                        "Invalid Tag",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
                // capitalize word 
                tag = char.ToUpper(tag[0]) + tag.Substring(1);

                // check for duplicates
                foreach (string existingTag in lbxMDTags.Items)
                {
                    if (existingTag.Equals(tag, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(
                            "This tag already exists.",
                            "Duplicate Tag",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }

                // add to textbox
                lbxMDTags.Items.Add(tag);

                // user can type the next tag
                txtAddTags.Clear();
                txtAddTags.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid String\n" + ex.Message,
                                "Update error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private bool ValidateTags(string tags)
        {
            return !string.IsNullOrWhiteSpace(tags);
        }

        private void lblFilePath_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // enter key control for adding tags
        private void txtAddTags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddTags.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
