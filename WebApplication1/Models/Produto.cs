
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoGabrielDDDMVC.Models
{
    public class Produto
    {
       
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public string Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool IsDisponivel { get; set; }
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        [NotMapped]
        public string nomecliente { get; set; }

    }
}