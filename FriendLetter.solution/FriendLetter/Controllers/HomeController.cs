using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye"; }
    [Route("/")]
    public ActionResult Letter() 
    { 
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Johann";
      myLetterVariable.Sender = "Philip";
      return View(myLetterVariable);
    }
  }
}