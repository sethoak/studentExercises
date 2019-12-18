﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesAPI.Models
{
    public class Instructors
    {
        public int Id { get; set; }
        public int CohortId { get; set; }
        public Instructors Instructor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
