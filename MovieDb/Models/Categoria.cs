﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDb.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        public ICollection<Filme> Filmes { get; set; }

        [NotMapped]
        public int Qtd
        { 
            get { if (Filmes == null) return 0; else return Filmes.Count; }
        }
    }
}

