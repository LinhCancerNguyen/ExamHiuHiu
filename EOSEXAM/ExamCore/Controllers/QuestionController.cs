﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ExamCore.Models;
using ExamCore.ModelViews;
using ExamCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamCore.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestion _Question;
        private readonly ISubject _Subject;
        private readonly IOption _Option;

        public QuestionController(IQuestion _IQuestion, IOption _IOption, ISubject _ISubject)
        {
             _Question = _IQuestion;
            _Subject = _ISubject;
            _Option = _IOption;
        }

        public IActionResult Index()
        {
            return View(_Question.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var Subjects = _Subject.All;
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Question model)
        {
            if (ModelState.IsValid)
            {
                _Question.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            var question = _Question.GetQuestion(Id);
            if (question == null)
            {
                return RedirectToAction("Index");
            }
            return View(question);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Question.Remove(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            var question = _Question.GetQuestion(Id);
            if (question == null)
            {
                return RedirectToAction("Index");
            }
            return View(question);
        }

        [HttpPost]
        public IActionResult Edit(Question Question)
        {
            if (ModelState.IsValid)
            {
                _Question.Edit(Question);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Detail(int? Id)
        {
            var question = _Question.GetQuestion(Id);
            if (question == null)
            {
                return RedirectToAction("Index");
            }
            dynamic models = new ExpandoObject();
            models.Question = question;
            models.Options = _Option.GetOptionsByQuestionId(Id);
            models.OptionTrue = _Option.GetTrueOption(Id);
            return View(models);
        }
    }
}
