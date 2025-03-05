using System;  // DateTime için

namespace GTM.Core.Entities
{
    public class LessonPlan
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public string Topic { get; set; } = string.Empty;
        public DateTime ScheduledAt { get; set; }
    }
}
