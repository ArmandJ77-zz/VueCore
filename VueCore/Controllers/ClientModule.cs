using VueCore.Models;
using Newtonsoft.Json;
using System.Linq;
using Nancy.ModelBinding;

namespace VueCore.Controllers
{
    public sealed class ClientModule : BaseModule
    {
        public ClientModule()
        {
            Get("/client/counter", args => new { count = Clients.ClientList.Count() });
            Get("/client", args => JsonConvert.SerializeObject(Clients.ClientList));
            Post("/client", args =>
            {
                var entity = this.Bind<Client>();
                entity.Id = Clients.ClientList.Count();
                Clients.ClientList.Add(entity);
                return new { Id = Clients.ClientList.Count()};
            });
        }
    }
}
