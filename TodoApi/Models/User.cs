using System.Collections.Generic;

namespace TodoApi.Models
{
    public class User
    {
        public int id { get; set; }
        public string nume { get; set; } = string.Empty;
        public string prenume { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string parola { get; set; } = string.Empty;
        public bool? admin { get; set; }



    }
}
