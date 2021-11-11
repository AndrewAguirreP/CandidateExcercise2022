using DayApp.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DayApp.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        //Challenge 1:
        //Call this api endpoint on your api testing tool
        //Call should display "Hello World!"
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hello World!");
        }

        //Challenge 2:
        //Modify Get API that accepts a string value of "name parameter input"
        //API should return a value sample input=Elmer, "Hello Elmer!"

        //[YOUR CODE HERE]

        //Challenge 3:
        //Create a new API endpoint to GET the people below from the method  GetPeopleAsync(DepartmentType department)
        //Constraints
        //////Update fix GetPeopleAsync to filter the people list by [department] using [DepartmentType] enum Sort the people list by [FirsName] Descending
        //////Api should have a route "list" appended, sample route "facebook/user/[list]"
        //////Api should be asynchrounous
        //////Api will receive a parameter DepartmentType to filter the results by department
        //////Api should check if result is empty, then return status code 204
        //////Api should return status code 200 when there is data on the list from GetPeopleAsync(DepartmentType department)

        //[YOUR CODE HERE]

        //Challenge 4:
        ///Create a new api endpoint that can modify [isActive] property from the list GetPeopleAsync()
        //Constraints
        ///Api should accept parameter person id and a boolean to activate/inactivate the person
        ///Api should be asynchrounous
        ///api will return 404 status code when person is not in the list
        ///api should return 200 with Person model showing that the IsActive status is changed base from the request

        //[YOUR CODE HERE]

        //////Update fix GetPeopleAsync to filter the people list by [department] using [DepartmentType] enum Sort the people list by [FirsName] Descending
        public async Task<IEnumerable<Person>> GetPeopleAsync(DepartmentType department)
        {
            await Task.Delay(100);

            var people = new List<Person>()
            {
                new Person(){ Id = 123, FirstName = "Zion", LastName = "Carter", Department = "Administration"},
                new Person(){ Id = 124, FirstName = "Jane", LastName = "Rodd", Department = "Administration"},
                new Person(){ Id = 125, FirstName = "Pete", LastName = "Pan", Department = "Administration"},
                new Person(){ Id = 126, FirstName = "Cole", LastName = "Man", Department = "Administration"},
                new Person(){ Id = 127, FirstName = "Amie", LastName = "King", Department = "Administration"},
                new Person(){ Id = 128, FirstName = "Paul", LastName = "Runner", Department = "Administration"},
                new Person(){ Id = 128, FirstName = "Paul", LastName = "Staff", Department = "Staff"},
            };

            return people;
        }

        #region DONT CHANGE CODE -- NOT PART OF TEST

        public async Task<IEnumerable<Person>> GetPeopleAsync()
        {
            await Task.Delay(100);

            return new List<Person>()
            {
                new Person(){ Id = 123, FirstName = "Zion", LastName = "Carter", Department = "Administration"},
                new Person(){ Id = 124, FirstName = "Jane", LastName = "Rodd", Department = "Administration"},
                new Person(){ Id = 125, FirstName = "Pete", LastName = "Pan", Department = "Administration"},
                new Person(){ Id = 126, FirstName = "Cole", LastName = "Man", Department = "Administration"},
                new Person(){ Id = 127, FirstName = "Amie", LastName = "King", Department = "Administration"},
                new Person(){ Id = 128, FirstName = "Paul", LastName = "Runner", Department = "Administration"},
            }; 
        }

        #endregion
    }
}
