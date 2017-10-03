using System.Collections.Generic;
using Newtonsoft.Json;

namespace VueCore.Models
{
    public static class Clients
    {
        public static List<Client> ClientList =>
        JsonConvert.DeserializeObject<List<Client>>(@"[{
                            ""Id"": ""0"",
                            ""Name"": ""Frederick"",
                            ""LastName"": ""Archer"",
                            ""Email"": ""farcher0@wsj.com""
                          }, {
                            ""Id"": ""1"",
                            ""Name"": ""Meara"",
                            ""LastName"": ""Horley"",
                            ""Email"": ""mhorley1@ebay.co.uk""
                          }, {
                            ""Id"": ""2"",
                            ""Name"": ""Addia"",
                            ""LastName"": ""Gambles"",
                            ""Email"": ""agambles2@wikispaces.com""
                          }, {
                            ""Id"": ""3"",
                            ""Name"": ""Hart"",
                            ""LastName"": ""MacDermot"",
                            ""Email"": ""hmacdermot3@pen.io""
                          }, {
                            ""Id"": ""4"",
                            ""Name"": ""Ki"",
                            ""LastName"": ""Lavallin"",
                            ""Email"": ""klavallin4@guardian.co.uk""
                          }, {
                            ""Id"": ""5"",
                            ""Name"": ""Jacklin"",
                            ""LastName"": ""Danford"",
                            ""Email"": ""jdanford5@amazon.co.uk""
                          }, {
                            ""Id"": ""6"",
                            ""Name"": ""Rod"",
                            ""LastName"": ""Cuxon"",
                            ""Email"": ""rcuxon6@google.pl""
                          }, {
                            ""Id"": ""7"",
                            ""Name"": ""Care"",
                            ""LastName"": ""Rogge"",
                            ""Email"": ""crogge7@utexas.edu""
                          }, {
                            ""Id"": ""8"",
                            ""Name"": ""Shaina"",
                            ""LastName"": ""Weitzel"",
                            ""Email"": ""sweitzel8@a8.net""
                          }, {
                            ""Id"": ""9"",
                            ""Name"": ""Noel"",
                            ""LastName"": ""Cowerd"",
                            ""Email"": ""ncowerd9@chicagotribune.com""
                          }]");
    }
}
