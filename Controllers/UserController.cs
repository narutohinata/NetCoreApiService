using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetFrameworkLeaner.Models;

namespace NetFrameworkLeaner.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly PersonContext _context;
		public UserController(PersonContext context)
		{
			_context = context;
		}

		// GET: api/User
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Person>>> GetUsers()
		{
			if(_context.Users == null)
			{
				return NotFound();
			}

			return await _context.Users.ToListAsync();

		}

		// POST api/User
		[HttpPost]
		public async Task<ActionResult<Person>> CreateUser(Person person)
		{
			if (_context.Users == null)
			{
				return Problem("error");
			}
			_context.Users.Add(person);
			await _context.SaveChangesAsync();

			return person;
		}
	}
}

