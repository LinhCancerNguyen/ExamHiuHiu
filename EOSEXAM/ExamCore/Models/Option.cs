﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamCore.Models
{
    public class Option
    {
        public virtual int Id { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public virtual string Content { get; set; }       
        public bool IsRight { get; set; }        
    }
}
