using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Heritage.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ContactModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string prenom { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string commentaire { get; set; }
    }
}