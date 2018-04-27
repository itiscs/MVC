using IdentityApp.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IdentityApp.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        ApplicationUserManager userManager;

        public UsersController()
        {
            userManager = new ApplicationUserManager(
                new UserStore<ApplicationUser>(db));
        }



        // GET: Users
        public ActionResult Index()
        {   
            return View(userManager.Users);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public async Task<ActionResult> Create([Bind(Include ="UserName,PhoneNumber,Email")] ApplicationUser user)
        {
            var result = await userManager.CreateAsync(user, "123456");
            if(result.Succeeded)
                 return RedirectToAction("Index");

            return View();
            
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
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

        // GET: Users/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeletePost(string id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var user = await userManager.FindByIdAsync(id);
                if(user == null)
                {
                    return new HttpNotFoundResult();
                }
                await userManager.DeleteAsync(user);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
