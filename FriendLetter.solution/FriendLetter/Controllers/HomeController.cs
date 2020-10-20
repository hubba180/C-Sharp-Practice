using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye"; }
    [Route("/")]
    public ActionResult Letter() { return View(); }
  }
}