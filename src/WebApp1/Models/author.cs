using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class author
    {
        [ScaffoldColumn(false)]
        public int AuthorID { get; set; }
        [Required]

        [Display(Name = "Last Name")]
        public string LastName { get; set;  }

        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        public virtual ICollection<book> books { get; set; }
    }
}
