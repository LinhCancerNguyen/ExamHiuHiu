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
    public class QuestionRepository : IQuestion
    {
        private ExamContext Db = null;

        public QuestionRepository(ExamContext _Db)
        {
            Db = _Db;
        }

        public IEnumerable<Question> All => Db.Question;

        public void Add(Question _Question)
        {
            Db.Question.Add(_Question);
            Db.SaveChanges();
        }

        public void Edit(Question _Question)
        {
            Db.Entry(_Question).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public Question GetQuestion(int? Id)
        {
            var Question = GetAll().Where(q => q.Id == Id);
            return Question.First();
        }

        public void Remove(int? Id)
        {
            Db.Question.Remove(Db.Question.Find(Id));
            Db.SaveChanges();
        }

        public IEnumerable<Question> GetAll()
        {
            var Questions = from q in Db.Question
                            join s in Db.Subject
                            on q.SubjectId equals s.Id
                            select new Question {
                                Id = q.Id,
                                SubjectId = q.SubjectId,
                                Subject = s,
                                Content = q.Content
                            };
            return Questions.ToList();
        }
    }
}
