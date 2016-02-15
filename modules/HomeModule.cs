using Nancy;
using PingPongNS.Objects;
using System.Collections.Generic;

namespace PingPongNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => { return View["header.cshtml"];
      };
    }
  }
}
