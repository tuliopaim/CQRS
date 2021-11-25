﻿using Core.Domain;

namespace Cadastro.Domain.Entities
{
    public class Pessoa : AuditableEntity
    {
        public Pessoa(string nome, byte idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; private set; }
        public byte Idade { get; private set; }

        public void AlterarNome(string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome)) return;

            Nome = novoNome;
        }

        public void AlterarIdade(byte novaIdade)
        {
            if (novaIdade < 18) return;

            Idade = novaIdade;
        }
    }
}