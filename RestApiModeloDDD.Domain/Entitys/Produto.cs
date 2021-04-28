namespace ProjetoGabrielDDD.Domain.Entitys
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public bool IsDisponivel { get; set; }
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }


      
     
    }
}
