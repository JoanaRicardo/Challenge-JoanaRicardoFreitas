using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Challenge__Web.Models {
    public partial class Team {
        [Key]
        public int TeamId { get; set; }

        public string Name { get; set; }
    }
}