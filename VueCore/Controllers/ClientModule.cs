using VueCore.Models;
using Newtonsoft.Json;
using System.Linq;
namespace VueCore.Controllers
{
    public sealed class ClientModule : BaseModule
    {
        public ClientModule()
        {
            Get("/counter", args => new { count = Clients.ClientList.Count() });
        }
    }
}
