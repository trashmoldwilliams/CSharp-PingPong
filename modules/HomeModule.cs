using Nancy;
using PingPongNS.Objects;
using System.Collections.Generic;

namespace PingPongNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => { return View["pingpong.cshtml", new List<string> {}];
      };

      Post["/pingpong"] = _ =>
      {
        List<string> model = PingPong.Play(Request.Form["number"]);
        return View["pingpong.cshtml", model];
      };
    }
  }
}
