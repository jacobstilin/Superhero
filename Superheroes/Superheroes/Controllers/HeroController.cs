using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class HeroController : Controller
    {
        ApplicationDbContext context;

        public HeroController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Hero
        public ActionResult Index()
        {
            return View();
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            Hero hero = context.Heroes.FirstOrDefault(i => i.Id == id);
            return View(hero);
        }

        public ActionResult List()
        {
            List<Hero> superheroes = context.Heroes.ToList();
            return View(superheroes);
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            Hero hero = new Hero();
            return View(hero);
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Heroes.Add(hero);
                context.SaveChanges();
                
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            Hero hero = context.Heroes.FirstOrDefault(i => i.Id == id);
            return View(hero);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Hero hero)
        {
            try
            {
                // TODO: Add update logic here
                var editId = context.Heroes.FirstOrDefault(i => i.Id == hero.Id);
                editId.heroName = hero.heroName;
                editId.altEgo = hero.altEgo;
                editId.primary = hero.primary;
                editId.secondary = hero.secondary;
                editId.catchphrase = hero.catchphrase;
                context.SaveChanges();
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            Hero hero = context.Heroes.FirstOrDefault(i => i.Id == id);
            return View(hero);
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                // TODO: Add delete logic here
                var deleteId = context.Heroes.FirstOrDefault(i => i.Id == hero.Id);
                context.Heroes.Remove(deleteId);
                context.SaveChanges();
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }


    }
}
