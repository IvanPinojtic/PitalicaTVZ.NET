using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DALPitalicaTVZ.Entities
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int CreatorId { get; set; }
        public string ExamName { get; set; }
        public int MaxScore { get; set; }
        public DateTime WriteDate { get; set; } = DateTime.Now;

        public virtual User User { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ExamResult> TestResults { get; set; }
    }
}
