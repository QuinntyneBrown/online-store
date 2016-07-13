namespace OnlineStore.Models
{
    public class SocialShare
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string OnImageSrc { get; set; }
        public string OffImageSrc { get; set; }
        public bool IsDeleted { get; set; }
    }
}
