using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutAPI.Models
{
    public class Category
    {
        /// <summary>
        /// ID from SQL.
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// This is the workout name.
        /// </summary>
        public string NameOfWorkout { get; set; } = "";

        /// <summary>
        /// This is the workout muscle group category.
        /// </summary>
        public string MuscleGroup { get; set; } = "";
    }
}