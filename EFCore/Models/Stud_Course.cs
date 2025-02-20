using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{ 
	[Table("Stud_CourseTable")]

    internal class Stud_Course
    {
        [Key]

        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public double Grade { get; set; }

    }
}
