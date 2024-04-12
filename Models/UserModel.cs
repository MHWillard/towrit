using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models;

public class UserModel
{
    public UserModel() { }
    public UserModel(int UserID, string UserName, string UserEmail, DateTime JoinDate) { 
        this.UserID = UserID;
        this.UserName = UserName;
        this.UserEmail = UserEmail;
        this.JoinDate = JoinDate;
    }

    public int UserID { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public DateTime JoinDate { get; set; }

    //UserID, UserName, UserEmail, JoinDate

}
