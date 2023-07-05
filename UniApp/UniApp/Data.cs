using System;
using UniApp.Models;

namespace UniApp
{
	public static class Data
	{
		public static List<Student> Students = new List<Student> {


			new Student { Id = 1, Name = "Furkan", Surname = "Amirli" },

            new Student { Id = 2, Name = "Nahid", Surname = "Amirli" },

            new Student { Id = 3, Name = "Felaket", Surname = "Amirli" }


        };
        public static List<Group> Groups = new List<Group> {


            new Group {  Name = "P137", Capacity = 18 },
            new Group {  Name = "B137", Capacity = 16 },
            new Group {  Name = "E137", Capacity = 32 },



        };



    }
}

