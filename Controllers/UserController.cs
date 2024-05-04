using CRUD_application_2.Models;
using System;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: User
        public ActionResult Index(string searchString)
        {
            var users = userlist;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.Name.Contains(searchString) || s.Email.Contains(searchString)).ToList();
            }

            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Add the new user to the userlist
                userlist.Add(user);
                // Redirect to the Index action to display the updated list of users
                return RedirectToAction("Index");
            }
            // If there are validation errors, return the Create view to display the errors
            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            var existingUser = userlist.FirstOrDefault(u => u.Id == id);
            if (existingUser == null)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                // Update the existing user's information
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                //existingUser.Age = user.Age;

                // Redirect to the Index action to display the updated list of users
                return RedirectToAction("Index");
            }

            // If there are validation errors, return the Edit view to display the errors
            return View(user);
        }

        // GET: User/Delete/5
        // This action method handles the HTTP GET request to delete a user.
        // It receives the user's ID as a parameter.
        public ActionResult Delete(int id)
        {
            // Find the user in the userlist using the provided ID.
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If the user is not found in the userlist, return a 404 Not Found status.
            if (user == null)
            {
                return HttpNotFound();
            }

            // If the user is found, return the Delete view for that user.
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            userlist.Remove(user);
            return RedirectToAction("Index");
        }
               
    }
}
