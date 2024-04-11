using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [Table("Post")]
    public class PostModel
    {
        public PostModel(int PostID, string PostTitle, string PostContent, DateTime PostDate)
        {
            this.PostID = PostID;
            this.PostTitle = PostTitle;
            this.PostContent = PostContent;
            this.PostDate = PostDate;
        }

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
