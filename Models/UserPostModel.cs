using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models;

public class UserPostModel
{
    public UserPostModel(int UserPostID, int UserID, int PostID)
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
