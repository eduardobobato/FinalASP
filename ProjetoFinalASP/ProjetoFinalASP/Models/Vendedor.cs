using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalASP.Models
{
    [Table("Vendedores")]
    public class Vendedor : Usuario
    {
        [Key]
        public int idVendedor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Nome do vendedor")]
        public string NomeVendedor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="CPF")]
        public int CpfVendedor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Data de nascimento")]
        [DataType(DataType.MultilineText)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Telefone")]
        public int  Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }

    }
}