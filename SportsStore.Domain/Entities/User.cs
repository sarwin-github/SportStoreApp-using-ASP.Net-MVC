using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
