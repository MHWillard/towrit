using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [Table("Post")]
    public class Post
    {

        [Key, Required]
        public int PostID { get; set; }
        [Required]
        public string PostTitle { get; set; }
        [Required]
        public string PostContent { get; set; }
        [Required]
        public DateTime PostDate { get; set; }

        //PostID, PostTitle, PostContent, PostDate
    }
}
