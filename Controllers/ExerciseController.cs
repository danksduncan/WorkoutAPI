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
    ///  This is where you can find each workout and its respective muscle group.
    /// </summary>
    public class ExerciseController : ApiController
    {
        List<Category> exercise = new List<Category>();
        public ExerciseController()
        {
            exercise.Add(new Category { NameOfWorkout = "Bench Press", MuscleGroup = "Chest", Id = 1 });
            exercise.Add(new Category { NameOfWorkout = "Weighted Curls", MuscleGroup = "Biceps", Id = 2 });
            exercise.Add(new Category { NameOfWorkout = "Barbell Squat", MuscleGroup = "Legs", Id = 3 });
        }

        /// <summary>
        /// Gets a list of names of each workout.
        /// </summary>
        /// <returns>A list of workout names.</returns>

        [Route("api/Exercise/GetNameOfWorkout")]
        [HttpGet]
        public List<string> GetNameOfWorkout()
        {
            List<string> output = new List<string>();
            foreach (var z in exercise)
            {
                output.Add(z.NameOfWorkout);
            }

            return output;
        }

        public List<Category> Get()
        {
            return exercise;
        }

        public Category Get(int id)
        {
            return exercise.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Post(Category val)
        {
            exercise.Add(val);
        }

        public void Delete(int id)
        {
        }
    }
}
