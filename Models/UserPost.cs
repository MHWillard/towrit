namespace App.Models;

public class UserPost
{
    public UserPost(int UserPostID, int UserID, int PostID)
    {
        this.UserPostID = UserPostID;
        this.UserID = UserID;
        this.PostID = PostID;
    }
    public int UserPostID { get; set; }
    public int UserID { get; set; }
    public int PostID { get; set; }
    //UserPostID, UserID, PostID
}
