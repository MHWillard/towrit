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
        /*
        private readonly DBHelper _db;
        public RestAPIController(DataContext _context) {
            _db = new DBHelper(_context);
        }*/
        private readonly DBHelper _db;
        public RestAPIController(DataContext dataContext)
        {
            _db = new DBHelper(dataContext);
        }

        // GET user
        [HttpGet]
        [Route("api/[controller]/GetUser")]
        public IActionResult GetUser(string username) {
            ResponseType type = ResponseType.Success;
            try
            {
                UserModel data = _db.GetUser(username);

                if (data == null)
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

            /*
            UserModel data = await _db.GetUser(username);
            if (data == null)
            {
                return NotFound();
            }

            return data;*/

        }

        // GET user posts
        [HttpGet]
        [Route("api/[controller]/GetPosts")]
        public IActionResult GetPosts(string username) {
            ResponseType type = ResponseType.Success;
            try
            {
                UserModel user = _db.GetUser(username);
                List<PostModel> posts = _db.GetPosts(user.UserID);

                if (posts == null)
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, posts));
                }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
              
            
            //get userPostModel
            //use that to look up posts
            //then finally return posts as a list
        }

        // POST new post
        [HttpPost]
        [Route("api/[controller]/AddPost")]
        public IActionResult AddPost(PostModel post, string username) {
            try
            {
                ResponseType type = ResponseType.Success;
                UserModel user = _db.GetUser(username);
                _db.AddPost(post, user.UserID);
                return Ok(ResponseHandler.GetAppResponse(type, post));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        // POST new user
        [HttpPost]
        [Route("api/[controller]/AddUser")]
        public IActionResult  AddUser(UserModel user) {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.AddUser(user);
                return Ok(ResponseHandler.GetAppResponse(type, user));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }


        }
    }
}
