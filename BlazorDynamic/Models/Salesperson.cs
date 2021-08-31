
using Microsoft.AspNetCore.Components;

namespace BlazorDynamic.Models;
    public partial class Salesperson : ComponentBase
    {
        public int? EmployeeID { get; set; }
        public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Title { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Postal { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }

        public static List<Salesperson> GetSalesperson()
        {
            List<Salesperson> Employees = new()
            {
                new Salesperson { EmployeeID = 1, FirstName = "Nancy", LastName = "Andrea", Email = "nancy.andr@gmail.com", Title = "Sales Representative", City = "New York", Country = "USA", Postal = "10007", Address = "507 - 20th Ave. E. Apt. 2A", Phone = "(212) 555-1189" },
                new Salesperson { EmployeeID = 2, FirstName = "Andrew", LastName = "Taylor", Email = "andrew.taylor@gmail.com", Title = "Vice President", City = "London", Country = "UK", Postal = "WC2H 0HH", Address = "908 W. Capital Way", Phone = "(71) 755-9489" },
                new Salesperson { EmployeeID = 3, FirstName = "Jenie", LastName = "Celine", Email = "celine_jeny@gmail.com", Title = "Region Manager", City = "London", Country = "UK", Postal = "WC2H 0HH", Address = "722 Moss Bay Blvd.", Phone = "(71) 235-5644" },
                new Salesperson { EmployeeID = 4, FirstName = "Margaret", LastName = "Lucy", Email = "margaret.lucy@gmail.com", Title = "Sales Manager", City = "London", Country = "UK", Postal = "WC2H 0HH", Address = "4110 Old Redmond Rd.", Phone = "(71) 555-4674" },
                new Salesperson { EmployeeID = 5, FirstName = "Steven", LastName = "Stalen", Email = "staley.steve@gmail.com", Title = "Sales VP", City = "Vegas", Country = "USA", Postal = "89107", Address = "14 Garrett Hill", Phone = "(212) 555-1189" },
                new Salesperson { EmployeeID = 6, FirstName = "Smith", LastName = "Joe", Email = "joe.smith@gmail.com", Title = "Sales Consultant", City = "New York", Country = "USA", Postal = "10007", Address = "Coventry House Miner Rd.", Phone = "(212) 555-1189" },
                new Salesperson { EmployeeID = 7, FirstName = "Steven", LastName = "Smith", Email = "smith.steve@gmail.com", Title = "Sales Coordinator", City = "Paris", Country = "France", Postal = "75007", Address = "Edgeham Hollow Winchester Way", Phone = "+331 4025 0808" },
                new Salesperson { EmployeeID = 8, FirstName = "Catherine", LastName = "Ray", Email = "ray_catherine@gmail.com", Title = "Sales Representative", City = "Mumbai", Country = "India", Postal = "400007", Address = "4726 - 11th Ave. N.E.", Phone = "022 43768823" },
                new Salesperson { EmployeeID = 9, FirstName = "Larry", LastName = "Reas", Email = "raes_larry@gmail.com", Title = "Sales Associate", City = "Chennai", Country = "India", Postal = "600077", Address = "7 Houndstooth Rd.", Phone = "044 41618442" }
            };
            return Employees;
        }
    }