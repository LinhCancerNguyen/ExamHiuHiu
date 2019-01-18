using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamCore.ModelViews
{
    public class AdminViewModel
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
    }
}
