﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Titulo { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string Icone { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string Tipo { get; set; } = "Despesa";
    }
}
