namespace App.Models;

public class UserPosts
{
    public int UserPostsID { get; set; }
    public int UserID { get; set; }

    public List<Post> FeedPosts { get; set; }
}
