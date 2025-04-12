using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;
using Newtonsoft.Json.Linq;

namespace MyPortfolioCore.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.Skills.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill sk)
        {
            context.Skills.Add(sk);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill sk)
        {
            context.Skills.Update(sk);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}