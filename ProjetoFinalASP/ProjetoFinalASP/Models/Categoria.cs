using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalASP.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int idCategoria { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Nome da categoria")]
        public string NomeCategoria { get; set; }

    }
}