using System.Collections.Generic;
using Newtonsoft.Json;

namespace VueCore.Models
{
    public static class Clients
    {
        public static List<Client> ClientList = new List<Client>
        {
          new Client
          {
            Id = 0,
            Name = "Frederick",
            LastName = "Archer",
            Email = "farcher0@wsj.com"
          },
          new Client
          {
            Id = 1,
            Name = "Meara",
            LastName = "Horley",
            Email = "mhorley1@ebay.co.uk"
          },
          new Client
          {
            Id = 2,
            Name = "Addia",
            LastName = "Gambles",
            Email = "agambles2@wikispaces.com"
          },
          new Client
          {
            Id = 3,
            Name = "Hart",
            LastName = "MacDermot",
            Email = "hmacdermot3@pen.io"
          }
        };
    }
}
