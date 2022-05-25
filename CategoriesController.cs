﻿using COMP_2084___Lab_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP_2084___Lab_2.Controllers
{

    public class CategoriesController : Controller
    {
        static List<CategoriesModel> CategoriesList = new List<CategoriesModel>
        {
            new CategoriesModel{Id = 1, Name = "Food"},
            new CategoriesModel{Id = 2, Name = "Tech"},
            new CategoriesModel{Id = 3, Name = "Sports"}
            };
    
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(CategoriesList);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var selected = CategoriesList.First<CategoriesModel>(x => x.Id == id);
            return View(selected);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

