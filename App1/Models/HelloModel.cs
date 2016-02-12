using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App1.Models
{
    public class HelloModel
    {
        public static List<Student> Getstd()
        {
            List<Student> std = new List<Student>
            {
                new Student {Id=1,Name="Ahmad1" },
                new Student {Id=2,Name="Ahmad1" },
                new Student {Id=3,Name="Ahmad1" }

            };
            return std;
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}