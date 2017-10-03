using System.Collections.Generic;
using Newtonsoft.Json;

namespace VueCore.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
