using System;
using System.Collections.Generic;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {
            Exercise Exercise1 = new Exercise ("Sandwich Maker", "Javascript");

            Exercise Exercise2 = new Exercise ("Tamagotchi", "Sass");

            Exercise Exercise3 = new Exercise ("Sports Roster", "ReactJS");

            Exercise Exercise4 = new Exercise ("Heist", "Csharp");
            /////////////////

            Cohort Cohort37 = new Cohort ("C37");

            Cohort CohortE10 = new Cohort ("E10");

            Cohort Cohort35 = new Cohort ("C35");
            ////////////////////

            Student Jasmine = new Student ("Williams", "Jasmine", "williaj", Cohort37);

            Student Maggie = new Student ("Greene", "Maggie", "maggieg", Cohort37);

            Student Crystal = new Student ("Broach", "Crystal", "broach44", CohortE10);

            Student Ashley = new Student ("Claiborne", "Ashley", "ac1986", Cohort35);
            ///////////////////

            Instructor Adam = new Instructor ("Adam", "Sheaffer", "asheaff", Cohort37, "blackboxes");

            Instructor Brenda = new Instructor ("Brenda", "Long", "blong", Cohort35, "star wars");

            Instructor Rose = new Instructor ("Rose", "Wiz", "rwizzy", CohortE10, "fashion");
            ///////////////////

            Adam.Assign (Exercise1, Exercise2, Jasmine);
            Adam.Assign (Exercise1, Exercise2, Maggie);
            Adam.Assign (Exercise1, Exercise2, Crystal);
            Adam.Assign (Exercise1, Exercise2, Ashley);

            Brenda.Assign (Exercise2, Exercise3, Jasmine);
            Brenda.Assign (Exercise2, Exercise3, Maggie);
            Brenda.Assign (Exercise2, Exercise3, Crystal);
            Brenda.Assign (Exercise2, Exercise3, Ashley);

            Rose.Assign (Exercise3, Exercise4, Jasmine);
            Rose.Assign (Exercise3, Exercise4, Maggie);
            Rose.Assign (Exercise3, Exercise4, Crystal);
            Rose.Assign (Exercise3, Exercise4, Ashley);
            //////////////////////

            List<Student> students = new List<Student> { Jasmine, Maggie, Crystal, Ashley };

            List<Exercise> exercises = new List<Exercise> { Exercise1, Exercise2, Exercise3, Exercise4 };

        }
    }
}