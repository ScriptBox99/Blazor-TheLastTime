﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheLastTime.Data
{
    public class Category
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public List<Habit> HabitList = new List<Habit>();
    }
}
