using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Attendance.Models
{
    [Table("Attendance")]
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Attendance Id")]
        public int AttendanceId { get; set; }

        [Display(Name = "Attendance Date Time")]
        public DateTime AttendanceDateTime { get; set; }

        [Display(Name = "Present")]
        public Boolean Present { get; set; }
    }
}