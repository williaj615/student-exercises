using System;
using System.Collections.Generic;

namespace StudentExercises {
  public class Student {

    //Properties
    public string FirstName { get; set; }

    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort CohortName { get; set; }

    public List<Exercise> exercises { get; set; } = new List<Exercise> ();

    // Methods

    //Constructor

    public Student (string lastName, string firstName, string handle, Cohort cohort) {
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = handle;
      CohortName = cohort;

    }
  }
}