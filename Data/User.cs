using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models;

[Table("User")]
public class User
{
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
