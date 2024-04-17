using App.Data;

namespace App.Models
{
    public class DBHelper
    {
        private DataContext _context;
        public DBHelper(DataContext context)
        {
            _context = context;
        }

        //methods needed: get user, get posts for a user, post user, post new post

        //GET
        public UserModel GetUser(string username) 
        {
            UserModel response = new UserModel();
            var row = _context.User.Where(d => d.UserName.Equals(username)).FirstOrDefault();
            return new UserModel(row.UserID, row.UserName, row.UserEmail, row.JoinDate);
            //UserID, UserName, UserEmail, JoinDate
        }

        public List<PostModel> GetPosts(int userid)
        {
            List<PostModel> response = new List<PostModel>();
            //here, it polls for the UserPost related to the userid. Then it uses that to query for all of the posts.
            var postList = _context.Posts.ToList();
            postList.ForEach(row => response.Add(new PostModel() {PostID = row.PostID, PostContent=row.PostContent, PostDate=row.PostDate, PostTitle=row.PostTitle}));
            //PostID, PostTitle, PostContent, PostDate
            return response;
        }

        //POST

        public void AddPost(PostModel post, int userid)
        {
            //get post, get userid
            //dump post itself into table
            //dup new userposts entry with post.id and userid
            PostModel newPost = new PostModel();
            UserPostModel newUserPost = new UserPostModel();
            newPost.PostID = post.PostID;
            newPost.PostContent = post.PostContent;
            newPost.PostDate = post.PostDate;
            newPost.PostTitle = post.PostTitle;
            newUserPost.UserID = userid;
            newUserPost.PostID += 1; //replace with other method later

            _context.Posts.Add(newPost);
            _context.UserPost.Add(newUserPost);
            _context.SaveChanges();
        }

        //DELETE


    }
}
