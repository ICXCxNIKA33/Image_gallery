using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ImageGallery.Models;

namespace Image_Gallery.Forms
{
    public partial class DebugForm : Form
    {
        private List<ImageData> images;

        // constructor, initializes local image list with MainForm ImageGallery list
        public DebugForm(List<ImageData> ImageGallery)
        {
            InitializeComponent();
            images = ImageGallery;
        }

        // refresh the image count label and list of images with updated information
        private void RefreshDisplay(List<ImageData> ImageGallery)
        {
            lblImageCount.Text = $"Images Loaded: {images.Count}";


            // clear and repopulate the ListBox of images
            lstImages.Items.Clear();

            foreach (ImageData image in images)
            {
                lstImages.Items.Add(image.FileName);
            }
        }

        private void btnGenerateTestData_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // call RefreshDisplay function
            RefreshDisplay(images);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
