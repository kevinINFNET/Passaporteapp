namespace PessoaPassaporteApp.Models
{
    public class Passaporte
    {
        public int PassaporteId { get; set; }
        public string Numero { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
