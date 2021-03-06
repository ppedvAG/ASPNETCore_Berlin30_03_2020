﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Todo.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }

        [DisplayName("Titel")]
        public string Title { get; set; }

        [DisplayName("Artikel")]
        [Required]
        [MinLength(20, ErrorMessage = "Artikel muss mindestens 20 Zeichen beinhalten")]
        public string Content { get; set; }

        [DisplayName("Erstellt am")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Erstellt von")]
        public string CreatedBy { get; set; }

        //[LargerThanValidation(10, ErrorMessage = "Bitte einen Wert größer als 10 bitte eingeben")]

        //public int Counter { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
