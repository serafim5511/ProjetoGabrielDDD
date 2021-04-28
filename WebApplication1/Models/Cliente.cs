﻿

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoGabrielDDDMVC.Models
{
        public class Cliente
        {
     

        [Key]
             public int Id { get; set; }

             [Required(ErrorMessage = "Preencha o campo Nome")]
             [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
             [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
             public string Nome { get; set; }

             [Required(ErrorMessage = "Preencha o campo Sobrenome")]
             [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
             [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
             public string Sobrenome { get; set; }

             [Required(ErrorMessage = "Preencha o campo E-mail")]
             [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
             [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
             [DisplayName("E-mail")]
             public string Email { get; set; }

             [ScaffoldColumn(false)]
             public DateTime DataCadastro { get; set; }

             public bool IsAtivo { get; set; }
         //public virtual Produto Produtos { get; set; }
         public virtual IEnumerable<Produto> Produtos { get; set; }
        

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.IsAtivo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
       

    }
}
