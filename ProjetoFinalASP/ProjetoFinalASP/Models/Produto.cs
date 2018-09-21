using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalASP.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int idProduto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Nome do produto")]
        public string  NomeProduto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Quantidade")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Categoria")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Valor")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
    }
}