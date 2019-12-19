using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorkoutAPI.Models;

namespace WorkoutAPI.Controllers
{
    /// <summary>
    ///  This is where I give you all the information about each person.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Flex", LastName = "Armstrong", Id = 1 });
            people.Add(new Person { FirstName = "Bo", LastName = "Flexington", Id = 2 });
            people.Add(new Person { FirstName = "Mack", LastName = "Jackedson", Id = 3 });
        }

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <returns>A list of first names.</returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }
        
        public List<Person> Get()
        {
            return people;
        }

        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Post(Person val)
        {
            people.Add(val);
        }

        public void Delete(int id)
        {
        }
    }
}
