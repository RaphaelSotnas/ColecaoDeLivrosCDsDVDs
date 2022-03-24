using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Controllers;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using ColecaoLivrosCDsDVDs.Servico.CDs;
using ColecaoLivrosCDsDVDs.Servico.DVDs;
using ColecaoLivrosCDsDVDs.Servico.Emprestimo;
using ColecaoLivrosCDsDVDs.Servico.Livros;
using Moq;
using System;
using Xunit;

namespace TestesUnitarios
{
    public class UnitTest1
    {

        //Mock<IColecaoRepository> colecaoRepositoryMock = new Mock<IColecaoRepository>();
        //Mock<ILivroServico> livroServicoMock = new Mock<ILivroServico>();
        //Mock<ICdServico> cdServicoMock = new Mock<ICdServico>();
        //Mock<IDvdServico> dvdServicoMock = new Mock<IDvdServico>();
        //Mock<IEmprestimoServico> emprestimoServicoMock = new Mock<IEmprestimoServico>();

        //[Fact]
        //public void TestandoCadastrarUmLivro()
        //{
        //    //Arrange
        //    LivroController livroController = new LivroController(livroServicoMock.Object);

        //    LivroRequest livroDoRaphael = new LivroRequest
        //    {
        //        Autor = "Raphael Santos",
        //        Genero = ColecaoLivrosCDsDVDs.Enum.Genero.Ficçao,
        //        Nome = "Raphael e suas histórias",
        //        Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel
        //    };

        //    //Act
        //    var resultado = livroController.CadastrarLivro(livroDoRaphael);
        //    var livroNoBanco = livroController.ListarLivros();

        //    ////Assert
        //    livroServicoMock.Verify(x => x.Listar().Contains(livroDoRaphael.Nome), Times.Once());
        //}
    }
}
