﻿using System.ComponentModel.DataAnnotations;

namespace GAM106.Models
{
    public class GameLevel
    {
        [Key]
        public int LevelId { get; set; }
        public string title { get; set; }
        public string? Description { get;set; }
    }
}