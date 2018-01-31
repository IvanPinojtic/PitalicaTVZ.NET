using System;
using System.Collections.Generic;
using System.Text;

namespace DALPitalicaTVZ.Entities
{
    public class UserExamTaken
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
