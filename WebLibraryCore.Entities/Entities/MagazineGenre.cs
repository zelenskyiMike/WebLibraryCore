﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebLibraryCore.Entities.Entities
{
    public class MagazineGenre
    {
        [Key]
        public int MagazineGenreID { get; set; }
        [Required]
        public string MagazineGenreName { get; set; }

        public List<Magazine> Magazines { get; } = new List<Magazine>();

    }
}
