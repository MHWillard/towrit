using App.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;

namespace App.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context) 
        {
            context.Database.EnsureCreated();
            if (context.User.Any())
            {
                return;
            }

            User[] users = 
            {
                new User(67061861, "user1", "user1@example.com", DateTime.Parse("2001-09-11")),
                new User(30575214, "user2", "user2@example.com", DateTime.Parse("2002-09-11")),
                new User(05823084, "user3", "user3@example.com", DateTime.Parse("2003-09-11"))
            };
            //UserID, UserName, UserEmail, JoinDate
            Post[] posts =
            {
                new Post(95896342, "User1 Post1","user1 post1 content",DateTime.Parse("2001-09-11")),
            };
            //PostID, PostTitle, PostContent, PostDate
            UserPost[] userPosts = { };
            //UserPostID, UserID, PostID

            //userid: 67061861 30575214 05823084
            //postid: 95896342 93005896 57173004 37906609
            //userpostid: 28247715 08783608 19792150
        }
    }
}
