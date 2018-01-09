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

        [ForeignKey("associatedModule")]
        public int ModuleId { get; set; }

        [ForeignKey("associatedStudent")]
        public String CollegeId { get; set; }

        [Display(Name = "Attendance Date Time")]
        public DateTime AttendanceDateTime { get; set; }

        [Display(Name = "Present")]
        public Boolean Present { get; set; }

        public virtual Module associatedModule { get; set; }

        public virtual Student associatedStudent { get; set; }
    }
}