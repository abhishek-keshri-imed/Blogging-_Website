namespace BloggingMVC.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }

        //public String? Heading { get; set; } // Nullable :
        //The ? indicates that the Heading property can hold either a string value or null.
        
        public String Heading { get; set; }

        public String PageTitle { get; set; }

        public String Content { get; set; }

        public String ShortDesc { get; set; }

        public String FeatureImageUrl { get; set; }

        public String UrlHandle { get; set; }

        public DateTime PublishDate { get; set; }

        public String Author { get; set; }

        public bool Visible { get; set; }

        //Used to define a one-to-many or many-to-many relationship between entities
        public ICollection<Tag> Tags { get; set; }
    }
}
