using System;
using System.Collections.Generic;

namespace StudentExercises {

  public class Exercise {

    // Properties
    public string ExerciseName { get; set; }

    public string Language { get; set; }

    // Methods

    // Constructor

    public Exercise (string name, string language) {
      ExerciseName = name;
      Language = language;
    }
  }
}