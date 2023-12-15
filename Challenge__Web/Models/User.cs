using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Challenge__Web.Models {

    public partial class User {
        [Key]
        public int UserId { get; set; }
        public int? TeamId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        [NotMapped]
        public virtual Team teams { get; set; }
    }
}