﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebLibraryCore.Entities.Entities
{
    public class ArticleAuthor
    {
        
        public int ArticleID { get; set; }
        
        public int AuthorID { get; set; }

        public Article Articles { get; set; }
        public Author Authors { get; set; }
    }
}
