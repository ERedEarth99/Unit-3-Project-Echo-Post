using EchoPost.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EchoPost.Controllers
{
	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}

	}
}
