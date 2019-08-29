using MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Controllers
{
    [Route("api/[controller]")]
    public class CollaboratorController : Controller
    {
        private readonly ApiContext _context;
        public CollaboratorController(ApiContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Collaborator> listCollaborators = new List<Collaborator>();
            listCollaborators = _context.Collaborators.ToList();

            return View(listCollaborators);
        }

        [HttpGet]
        public IActionResult Details()
        {
            System.Console.WriteLine("@Entrei no Controller");

            var collaborators = _context.Collaborators.ToList();
 
            return View(collaborators[0]);
        }
    }
}