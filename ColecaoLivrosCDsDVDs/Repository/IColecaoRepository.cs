﻿using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository
{
    public interface IColecaoRepository
    {
        void ExcluirPessoa(int id);
        void AtualizarPessoa(Pessoa pessooa);
        Pessoa BuscarPessoaPorId(int id);
        void CadastrarPessoa(Pessoa pessoa); 
        List<Pessoa> ListarPessoas();
        List<CD> ListarCDs();

        //List<DVD> ListarDVDs();
    }
}
