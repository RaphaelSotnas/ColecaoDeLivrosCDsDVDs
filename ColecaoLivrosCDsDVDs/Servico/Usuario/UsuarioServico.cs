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

        public bool Cadastrar(Usuario usuario)
        {
            try
            {
                return _colecaoRepository.CadastrarUsuario(usuario);
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

        public bool Atualizar(Usuario usuario)
        {
            try
            {
                return _colecaoRepository.AtualizarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                return _colecaoRepository.ExcluirUsuario(id);
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

        public Usuario DetalharUsuarioLivro(int idLivro)
        {
            try
            {
                return _colecaoRepository.DetalharUsuarioLivro(idLivro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario DetalharUsuarioCd(int idCd)
        {
            try
            {
                return _colecaoRepository.DetalharUsuarioCd(idCd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario DetalharUsuarioDvd(int idDvd)
        {
            try
            {
                return _colecaoRepository.DetalharUsuarioDvd(idDvd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> ListarDisponiveis()
        {
            throw new NotImplementedException();
        }
    }
}
