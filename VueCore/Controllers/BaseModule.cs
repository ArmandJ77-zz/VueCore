using Nancy;

namespace VueCore.Controllers
{
  public abstract class BaseModule : NancyModule
  {
    protected BaseModule() : base("/api")
    {
    }
  }
}
