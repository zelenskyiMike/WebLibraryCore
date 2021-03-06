﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebLibraryCore.Entities.Entities
{
    public class PublicationGenre
    {
        [Key]
        public int PublicationGenreID { get; set; }
        [Required]
        public string PublicationGenreName { get; set; }

        public List<Publication> Publications { get; } = new List<Publication>();
    }
}
