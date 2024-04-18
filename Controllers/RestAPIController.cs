using Microsoft.AspNetCore.Mvc;
using System.Web;
using App.Data;
using App.Models;

namespace App.Controllers
{
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
        public IActionResult Get(string username) {
            UserModel data = _db.GetUser(username);
            if (data == null)
            {
                return NotFound();
            }

            return View(data);

        }

        // GET user posts
        [HttpGet]
        [Route("api/[controller]/GetPosts")]
        public IActionResult Get(string username) {
            UserModel user = _db.GetUser(username);
            //get userPostModel
            //use that to look up posts
            //then finally return posts as a list
        }

        // POST new post
        [HttpPost]
        [Route("api/[controller]/AddPost")]
        public IActionResult Post() { }

        // POST new user
        [HttpPost]
        [Route("api/[controller]/AddUser")]
        public IActionResult Post() { }
    }
}
