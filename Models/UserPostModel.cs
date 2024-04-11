using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models;

[Table("UserPost")]

public class UserPostModel
{
    public UserPostModel(int UserPostID, int UserID, int PostID)
    {
        this.UserPostID = UserPostID;
        this.UserID = UserID;
        this.PostID = PostID;
    }

    [Key, Required]
    public int UserPostID { get; set; }
    [Required]
    public int UserID { get; set; }
    [Required]
    public int PostID { get; set; }
    //UserPostID, UserID, PostID
}
