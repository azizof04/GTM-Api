using System;  // DateTime için
using System.Collections.Generic;  // ICollection<> için
using GTM.Core.Entities;  // User ve LessonPlan'ı burada kullanabilmek için


namespace GTM.Core.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TeacherId { get; set; }
        public User? User {get; set;}
        public ICollection<LessonPlan>? LessonPlans { get; set; }  // Ders planları
    }
}
