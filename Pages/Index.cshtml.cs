using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentUsersApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PaymentUsersApp.Pages
{
    public class UsersModel : PageModel
    {
        // Create a DataAccessController object
        DataAccessController dac = new DataAccessController();

        // Create a collection for holding CoursesAndModules object
        public List<Users> Users;

        public void OnGet()
        {
            // Retrieve the data using the DataAccessController object and populate the CoursesAndModules object
            Users = dac.GetAllUsers().ToList();
        }
    }
}