namespace ImageGallery.Models
{
    public class ImageData
    {
        // fields for the ImageData class
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string fileExtension { get; set; }
        public DateTime DateAdded { get; set; }
        public int fileSize { get; set; }
        public string Description { get; set;  }
        public List<string> Tags { get; set; }

        

        // constructor, sets date and empty tags list automaticly 
        public ImageData()
        {
            Id = Guid.NewGuid();
            Tags = new List<string>();
            DateAdded = DateTime.Now;
        }
    }
}