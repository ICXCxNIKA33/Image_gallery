namespace ImageGallery.Models
{
    public class ImageData
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set;  }
        public List<string> Tags { get; set; }

        public ImageData()
        {
            Tags = new List<string>();
            DateAdded = DateTime.Now;
        }
    }
}