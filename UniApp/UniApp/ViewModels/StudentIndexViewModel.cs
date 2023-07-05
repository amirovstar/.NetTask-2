using System;
using UniApp.Models;

namespace UniApp.ViewModels
{
	public class StudentIndexViewModel { 
	
		public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
		public Student Student { get; set; }

    }
}

