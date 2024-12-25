namespace BloggingMVC.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String DisplayName { get; set; }

        //Used to define a one-to-many or many-to-many relationship between entities
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
