﻿using App.Models;
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

            UserModel[] users = 
            {
                new UserModel(67061861, "user1", "user1@example.com", DateTime.Parse("2001-09-11")),
                new UserModel(30575214, "user2", "user2@example.com", DateTime.Parse("2002-09-11")),
                new UserModel(05823084, "user3", "user3@example.com", DateTime.Parse("2003-09-11"))
            };
            //UserID, UserName, UserEmail, JoinDate
            PostModel[] posts =
            {
                new PostModel(95896342, "User1 Post1","user1 post1 content",DateTime.Parse("2001-09-11")),
                new PostModel(93005896, "User1 Post2","user1 post2 content",DateTime.Parse("2001-09-12")),
                new PostModel(57173004, "User2 Post1","user2 post1 content",DateTime.Parse("2001-10-11")),
                new PostModel(37906609, "User3 Post1","user3 post1 content",DateTime.Parse("2001-11-11"))
            };
            //PostID, PostTitle, PostContent, PostDate
            UserPostModel[] userPosts =
            {
                new UserPostModel(66073549, 67061861, 95896342),
                new UserPostModel(28247715, 67061861, 93005896),
                new UserPostModel(08783608, 30575214, 57173004),
                new UserPostModel(19792150, 05823084, 37906609)
            };
            //UserPostID, UserID, PostID

            //userid: 67061861 30575214 05823084
            //postid: 95896342 93005896 57173004 37906609
            //userpostid: 28247715 08783608 19792150
        }
    }
}
