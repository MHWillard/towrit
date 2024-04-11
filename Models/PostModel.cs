using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class PostModel
    {
        public PostModel(int PostID, string PostTitle, string PostContent, DateTime PostDate)
        {
            this.PostID = PostID;
            this.PostTitle = PostTitle;
            this.PostContent = PostContent;
            this.PostDate = PostDate;
        }

        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDate { get; set; }

        //PostID, PostTitle, PostContent, PostDate
    }
}
