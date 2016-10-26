using System;

namespace ActumTestProj.Models
{
    public class Аttendance
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Training Training { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
