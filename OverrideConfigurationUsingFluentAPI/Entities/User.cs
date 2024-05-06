using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationByConvention.Entities
{
    
    public class User
    {

        public int UserId { get; set; }
        public string Username { get; set; } = null!; 

    }
}
