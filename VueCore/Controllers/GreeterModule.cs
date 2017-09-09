namespace VueCore.Controllers
{
  public sealed class GreeterModule : BaseModule
  {
    public GreeterModule()
    {
      Get("/greeting", args => new { Message = "Greetings From NancyFx" });
    }
  }
}
