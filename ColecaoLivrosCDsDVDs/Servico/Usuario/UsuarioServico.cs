using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IColecaoRepository _colecaoRepository;
        public UsuarioServico(IColecaoRepository colecaoRepository)
        {
            _colecaoRepository = colecaoRepository;
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                _colecaoRepository.CadastrarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Usuario BuscarPorId(int id)
        {
            try
            {
                return _colecaoRepository.BuscarUsuarioPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> Listar()
        {
            try 
            {
                return _colecaoRepository.ListarUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualizar(Usuario usuario)
        {
            try
            {
                _colecaoRepository.AtualizarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _colecaoRepository.ExcluirUsuario(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario EfetuarLogin(string login, string senha)
        {
            try
            {
                return _colecaoRepository.EfetuarLogin(login, senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario DetalharUsuario(int id)
        {
            try
            {
                return _colecaoRepository.DetalharUsuario(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
