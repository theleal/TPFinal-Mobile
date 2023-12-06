﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPDMI6.Data
{
    public class Livro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Required]
        public string NomeLivro { get; set; }
        [Required]
        public string NomeAutor { get; set; }
        [Required] 
        public string EmailAutor { get; set; }
        [Required]
        public string ISBN { get; set; }
    }
}
