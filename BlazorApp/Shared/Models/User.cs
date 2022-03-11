using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlazorApp.Shared.Models
{
    public class User
    {
        public int Userid { get; set; }
        public string Customername { get; set; } = null!;
        public string Employee { get; set; } = null!;
        public string Ordernumber { get; set; } = null!;
        public string Menu { get; set; } = null!;
        public string Emailid { get; set; } = null!;
    }
}