namespace IUR.Models
{
    public class NewsDTO
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Category { get; set; } // e.g., "Announcements", "Events", "Updates"
        public string Link { get; set; } // URL for "Read More" link
        public DateTime PublishedDate { get; set; } // Date of the news item
    }
}
