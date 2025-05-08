using System;
using System.Collections.Generic;

namespace SmartSchool.Models
{
    public class Professor
    {
        public Professor() { }
        public Professor(int id, string name) 
        {
            this.Id = id;
            this.Name = name;
        }
    
        public int Id { get; set;}
        public string Name { get; set;}
        public IEnumerable<Subject> Subjects { get; set;}
    }
}