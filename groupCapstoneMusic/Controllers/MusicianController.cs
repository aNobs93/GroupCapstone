﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace groupCapstoneMusic.Controllers
{
    public class MusicianController : Controller
    {
        // GET: Musician
        public ActionResult Index()
        {
            return View();
        }

        // GET: Musician/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Musician/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Musician/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Musician/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Musician/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Musician/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Musician/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
