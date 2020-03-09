using System;
using System.Collections.Generic;

namespace StudentExercises {

  public class Cohort {

    // Properties
    public string CohortName { get; set; }

    public List<Student> students { get; set; } = new List<Student> ();

    public List<Instructor> instructors { get; set; } = new List<Instructor> ();

    // Methods

    // Constructor
    public Cohort (string name) {
      CohortName = name;
    }
  }
}