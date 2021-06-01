using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AT12_projet.Models;

namespace AT12_projet.Controllers
{
    public class ChauffeurController : Controller
    {
        public static List<Chauffeur> chauffeurs = new List<Chauffeur>()
        {
            new Chauffeur()
            {
                Id=1,
                Nom="Mazzouz",
                Prenom="Chaimae",
                Date_recrutement=DateTime.Now.AddYears(3),
                Salaire=30000M
            },
             new Chauffeur()
            {
                Id=2,
                Nom="Boutissante",
                Prenom="Issam",
                Date_recrutement=DateTime.Now.AddYears(3),
                Salaire=40000M
            },
        };
        // GET: Chauffeur
        public ActionResult Index()
        {
            return View(chauffeurs);
        }

        // GET: Chauffeur/Details/5
        public ActionResult Details(int id)
        {
            Chauffeur chauffeur = chauffeurs.Single(c => c.Id == id);
            return View(chauffeur);
        }

        // GET: Chauffeur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chauffeur/Create
        [HttpPost]
        public ActionResult Create(Chauffeur chauffeur)
        {
            try
            {
                // TODO: Add insert logic here
                chauffeurs.Add(chauffeur);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chauffeur/Edit/5
        public ActionResult Edit(int id)
        {
            Chauffeur chauffeur = chauffeurs.Single(c => c.Id == id);
            return View(chauffeur);
        }

        // POST: Chauffeur/Edit/5
        [HttpPost]
        public ActionResult Edit(Chauffeur chauffeur)
        {
            try
            {
                // TODO: Add update logic here
                Chauffeur ch = chauffeurs.Single(c => c.Id == chauffeur.Id);
                ch.Nom = chauffeur.Nom;
                ch.Prenom = chauffeur.Prenom;
                ch.Date_recrutement = chauffeur.Date_recrutement;
                ch.Salaire = chauffeur.Salaire;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chauffeur/Delete/5
        public ActionResult Delete(int id)
        {
            Chauffeur chauffeur = chauffeurs.Single(c => c.Id == id);
            return View(chauffeur);
        }

        // POST: Chauffeur/Delete/5
        [HttpPost]
        public ActionResult Delete(Chauffeur chauffeur)
        {
            try
            {
                // TODO: Add delete logic here
                Chauffeur ch = chauffeurs.Single(c => c.Id == chauffeur.Id);
                chauffeurs.Remove(ch);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
