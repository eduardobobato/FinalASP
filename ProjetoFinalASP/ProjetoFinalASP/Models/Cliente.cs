using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalASP.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Nome  do cliente")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="CPF do cliente")]
        public string CpfCliente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Telefone do Cliente")]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Nome da empresa")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "CNPJ da empresa")]
        public string CnpjEmpresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Telefone da empresa")]
        public string TelefoneEmpresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Endereço da empresa")]
        public string Endereco { get; set; }

    }
}