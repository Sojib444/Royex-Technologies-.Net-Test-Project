﻿namespace Royex.Domain.Entity
{
    public class OfficeExecutive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}