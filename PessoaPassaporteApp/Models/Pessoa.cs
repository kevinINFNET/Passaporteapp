﻿namespace PessoaPassaporteApp.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public Passaporte Passaporte { get; set; }
    }
}
