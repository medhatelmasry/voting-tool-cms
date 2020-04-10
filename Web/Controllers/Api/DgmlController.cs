using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;

namespace Web.Controllers.Api
{	
	[Route("Dgml")]
	public class DgmlController : Controller
	{
		public ApplicationDbContext _context { get; }


		public DgmlController( ApplicationDbContext context)
		{            
		  _context = context;						
		}
        

		[HttpGet]
		public IActionResult Get()
		{

			System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "\\Entities.dgml",
				_context.AsDgml(), 
                                System.Text.Encoding.UTF8);

                         var file = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + "\\Entities.dgml");
                         var response = File(file, "application/octet-stream", "Entities.dgml");
                         return response;
		}
    }
}