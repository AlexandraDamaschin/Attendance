using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Attendance.Models
{
    [Table("Module")]
    public class Module
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Module Id")]
        public int ModuleId { get; set; }

        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }
    }
}