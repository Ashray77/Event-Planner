using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlanner.Models
{
    public class RoleModel
    {
        [Key]
        public int role_id { get; set; }
        [Required(ErrorMessage ="Role must be entered.")]
        [Display(Name ="Role")]
        public string role { get; set; }
    }
}
