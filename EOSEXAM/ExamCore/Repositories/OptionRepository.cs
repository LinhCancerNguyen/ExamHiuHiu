using ExamCore.Data;
using ExamCore.Models;
using ExamCore.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamCore.Repositories
{
    public class OptionRepository : IOption
    {
        private ExamContext Db = null;

        public OptionRepository(ExamContext _Db)
        {
            Db = _Db;
        }

        public IEnumerable<Option> All => Db.Option;

        public void Add(Option _Option)
        {
            Db.Option.Add(_Option);
            Db.SaveChanges();
        }

        public void Edit(Option _Option)
        {
            Db.Entry(_Option).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public Option GetOption(int? Id)
        {
            return Db.Option.Find(Id);
        }

        public IEnumerable<Option> GetOptionsByQuestionId(int? questionId)
        {
            var Options = Db.Option.Where(o => o.QuestionId == questionId);
            return Options;
        }

        public Option GetTrueOption(int? questionId)
        {
            var Option = Db.Option.Where(o => o.QuestionId == questionId && o.IsRight == true).First();
            return Option;
        }

        public void Remove(int? Id)
        {
            Db.Option.Remove(Db.Option.Find(Id));
            Db.SaveChanges();
        }
    }
}
