using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using ImageGallery.Models;
// represents metadata for a gallery image

namespace Image_Gallery
{


    public partial class MainForm : Form
    {
        // list for holding ImageData objects
        private List<ImageData> imageGallery = new List<ImageData>();

        public MainForm()
        {
            InitializeComponent();



            // documented test code

            /* create a sample image objects
            ImageData image1 = new ImageData();
            image1.FileName = "sample.jpg";
            image1.FilePath = @"C:\images\sample.jpg";
            image1.Description = "Sprint 2 test image";

            ImageData image2 = new ImageData();
            image2.FileName = "forest.jpg";
            image2.FilePath = @"C:\Images\forest.jpg";
            image2.Description = "Forest test image";

            ImageData image3 = new ImageData();
            image3.FileName = "beach.jpg";
            image3.FilePath = @"C:\Images\beach.jpg";
            image3.Description = "Beach test image";

            // add tags
            image1.Tags.Add("Test");
            image2.Tags.Add("Nature");
            image3.Tags.Add("Vacation");

            // store in collection
            testImages.Add(image1);
            testImages.Add(image2);
            testImages.Add(image3);

            MessageBox.Show(
                $"Image 1: {image1.FileName} ({image1.Description})\n" +
                $"Image 2: {image2.FileName} ({image2.Description})\n" +
                $"Image 3: {image3.FileName} ({image3.Description})");

            MessageBox.Show(
                $"Image 1 Tags: {image1.Tags.Count}\n" +
                $"Image 2 Tags: {image2.Tags.Count}\n" +
                $"Image 3 Tags: {image3.Tags.Count}");

            MessageBox.Show(
                $"Image 1 Tag: {image1.Tags[0]}\n" +
                $"Image 2 Tag: {image2.Tags[0]}\n" +
                $"Image 3 Tag: {image3.Tags[0]}");

            MessageBox.Show($"Created {testImages.Count} test images.");

            string message = "";

            foreach (ImageData image in testImages)
            {
                message +=
                $"File Name: {image.FileName}\n" +
                $"File Path: {image.FilePath}\n" +
                $"Description: {image.Description}\n" +
                $"Date Added: {image.DateAdded}\n\n";
            }

            MessageBox.Show(message); */
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

        private void uploadImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // filter file types
            ofdUploadImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";

            // open file dialog title
            ofdUploadImage.Title = "Select an Image";

            // validate openFileDialog result
            if (ofdUploadImage.ShowDialog() == DialogResult.OK)
            {
                // get file path
                string filepath = ofdUploadImage.FileName;

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

                    // display image in picturebox
                    IGpictureBox1.Image = img;



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

                    // metadata debug test doucmentation
                    /*System.Diagnostics.Debug.WriteLine(
                        $"{imageInfo.FileName} | " +
                        $"{imageInfo.FilePath} | " +
                        $"{imageInfo.fileSize}"
                        );*/

                    // finally, add created image object to the list
                    imageGallery.Add(imageInfo);

                    // screen for testing list of files 
                    string message = "";

                    foreach (ImageData image in imageGallery)
                    {
                        message +=
                            $"Name: {image.FileName}\n" +
                            $"Path: {image.FilePath}\n" +
                            $"Extension: {image.fileExtension}\n" +
                            $"Size: {image.fileSize} bytes\n" +
                            $"Added: {image.DateAdded}\n\n";
                    }

                    MessageBox.Show(message);

                }
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
