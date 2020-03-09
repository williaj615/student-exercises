using System;
using System.Collections.Generic;

namespace StudentExercises {

  public class Instructor {
    // Properties
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string SlackHandle { get; set; }

    public Cohort Cohort { get; set; }

    public string Specialty { get; set; }

    // Methods
    public void Assign (Exercise exercise1, Exercise exercise2, Student student) {

      student.exercises.Add (exercise1);
      student.exercises.Add (exercise2);
    }

    //Constructor 

    public Instructor (string firstName, string lastName, string handle, Cohort cohort, string specialty) {
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = handle;
      Cohort = cohort;
      Specialty = specialty;
    }

  }
}