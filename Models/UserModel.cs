using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models;

[Table("User")]
public class UserModel
{
    public UserModel(int UserID, string UserName, string UserEmail, DateTime JoinDate) { 
        this.UserID = UserID;
        this.UserName = UserName;
        this.UserEmail = UserEmail;
        this.JoinDate = JoinDate;
    }

    [Key, Required]
    public int UserID { get; set; }
    [Required]
    public string UserName { get; set; }
    [Required]
    public string UserEmail { get; set; }
    [Required]
    public DateTime JoinDate { get; set; }

    //UserID, UserName, UserEmail, JoinDate

}
