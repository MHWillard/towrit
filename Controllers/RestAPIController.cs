using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Web;
using App.Data;
using App.Models;
using Microsoft.Extensions.Hosting;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestAPIController : Controller
    {
        private readonly DBHelper _db;
        public RestAPIController(DataContext _context) {
            _db = new DBHelper(_context);
        }

        // GET user
        [HttpGet]
        [Route("api/[controller]/GetUser")]
        public async Task<IActionResult> GetUser(string username) {
            UserModel data = await _db.GetUser(username);
            if (data == null)
            {
                return NotFound();
            }

            return View(data);

        }

        // GET user posts
        [HttpGet]
        [Route("api/[controller]/GetPosts")]
        public async Task<IActionResult> GetPosts(string username) {
            try
            {
                UserModel user = await _db.GetUser(username);
                List<PostModel> posts = await _db.GetPosts(user.UserID);
                return View(posts);
            } catch (Exception ex)
            {
                return NotFound();
            }
            }
            
            //get userPostModel
            //use that to look up posts
            //then finally return posts as a list
        }

        // POST new post
        [HttpPost]
        [Route("api/[controller]/AddPost")]
        public async Task<IActionResult> AddPost(PostModel post, string username) {
        try {
            UserModel user = await _db.GetUser(username);
            await _db.AddPost(post, user.UserID);
        } catch (Exception ex) {
            return NotFound();
        }

    }

        // POST new user
        [HttpPost]
        [Route("api/[controller]/AddUser")]
        public async Task<IActionResult>  AddUser(UserModel user) {
        try
        {
            await _db.AddUser(user);
        }
        catch (Exception ex)
        {
            return NotFound();
        }
    }
    }
}
