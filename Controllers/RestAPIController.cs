using Microsoft.AspNetCore.Mvc;
using App.Data;
using App.Models;

namespace App.Controllers
{
    public class RestAPIController : Controller
    {
        private readonly DBHelper _db;
        public RestAPIController(DataContext _context) {
            _db = new DBHelper(_context);
        }

        // GET user
        // GET user posts
        // POST new post
        // POST new user
    }
}
