using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DotNet5Crud.Models
{
    [Keyless]
    public class Userinfo
    {
        public string LId { get; set; }
        public string LoginId { get; set; }

        public string Pasword { get; set; }
    }
}
