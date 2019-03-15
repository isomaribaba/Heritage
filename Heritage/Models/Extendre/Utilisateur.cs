using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Heritage.Models
{
    [MetadataType(typeof(UtilisateurData))]
    public  partial class Utilisateur
    {

    }
    public class UtilisateurData
    {
        [Display(Name ="Nom")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nom required")]
        public string Nom { get; set; }

        [Display(Name = "Prenom")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Prenom required")]
        public string Prenom { get; set; }

        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Designation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Designation required")]
        public string Designation { get; set; }

        [Display(Name = "TypeUtilisateur")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Typeutilsateur required")]
        public string Typeutilsateur { get; set; }
    }
}