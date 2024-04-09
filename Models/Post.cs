namespace App.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string PostTitle { get; set; }

        public DateTime CreatedAt { get; set; }
        public string PostContent { get; set; }
    }
}
