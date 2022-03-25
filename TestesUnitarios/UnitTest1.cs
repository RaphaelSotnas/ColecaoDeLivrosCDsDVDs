using ColecaoLivrosCDsDVDs.Context.LivroContext;
using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Controllers;
using ColecaoLivrosCDsDVDs.Models.Contrato;
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
        [Fact(DisplayName = "Deveria cadastrar um livro")]
        public void TestandoCadastrarUmLivro()
        {
            //Arrange
            var livroServicoMock = new Mock<ILivroServico>();

            LivroRequest livroDoRaphael = new()
            {
                Autor = "Raphael Santos",
                Genero = ColecaoLivrosCDsDVDs.Enum.Genero.Ficçao,
                Nome = "Raphael Silva",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel
            };
            var livro = new Livro(livroDoRaphael);

            //Act
            var resultado =  livroServicoMock.Setup(x => x.Cadastrar(livro)).Returns(true);

            ////Assert
            Assert.True(livroServicoMock.Object.Cadastrar(livro));
        }

        [Fact(DisplayName = "Deveria cadastrar um Cd")]
        public void TestandoCadastrarUmCd()
        {
            //Arrange
            var cdServicoMock = new Mock<ICdServico>();

            CdRequest cdDoRaphael = new()
            {
                Nome = "Raphael Songs",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel,
                GeneroMusical = ColecaoLivrosCDsDVDs.Enum.GeneroMusical.MPB,
                Cantor = "Raphael Silva"
            };
            var cd = new CD(cdDoRaphael);

            //Act
            var resultado = cdServicoMock.Setup(x => x.Cadastrar(cd)).Returns(true);

            ////Assert
            Assert.True(cdServicoMock.Object.Cadastrar(cd));
        }

        [Fact(DisplayName = "Deveria cadastrar um Dvd")]
        public void TestandoCadastrarUmDvd()
        {
            //Arrange
            var dvdServicoMock = new Mock<IDvdServico>();

            DvdRequest dvdRequest = new()
            {
                Nome = "As Aventuras de Raph's",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel,
                Genero = ColecaoLivrosCDsDVDs.Enum.Genero.Comedia
            };
            var dvd = new DVD(dvdRequest);

            //Act
            var resultado = dvdServicoMock.Setup(x => x.Cadastrar(dvd)).Returns(true);

            ////Assert
            Assert.True(dvdServicoMock.Object.Cadastrar(dvd));
        }

        [Fact(DisplayName = "Deveria pegar emprestado um Livro")]
        public void TestandoCriarUmLivro_DepoisPegarEmprestado()
        {
            //Arrange
            var emprestimoServicoMock = new Mock<IEmprestimoServico>();

            LivroRequest livro = new()
            {
                Autor = "A História de Machado de Assis",
                Genero = ColecaoLivrosCDsDVDs.Enum.Genero.Romance,
                Nome = "Machado de Assis",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel
            };
            var livroParaPegar = new Livro(livro);

            //Act
            emprestimoServicoMock.Setup(x => x.EfetuarEmprestimoLivro(livroParaPegar.Id)).Returns(true);

            ////Assert
            Assert.True(emprestimoServicoMock.Object.EfetuarEmprestimoLivro(livroParaPegar.Id));
        }

        [Fact(DisplayName = "Deveria pegar emprestado um Cd")]
        public void TestandoCriarUmCd_DepoisPegarEmprestado()
        {
            //Arrange
            var emprestimoServicoMock = new Mock<IEmprestimoServico>();

            CdRequest cd = new()
            {
                Cantor = "Corey Taylor",
                GeneroMusical = ColecaoLivrosCDsDVDs.Enum.GeneroMusical.Rock,
                Nome = "Slipknot",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel
            };
            var cdParaPegar = new CD(cd);

            //Act
            emprestimoServicoMock.Setup(x => x.EfetuarEmprestimoCd(cdParaPegar.Id)).Returns(true);

            ////Assert
            Assert.True(emprestimoServicoMock.Object.EfetuarEmprestimoCd(cdParaPegar.Id));
        }

        [Fact(DisplayName = "Deveria pegar emprestado um Dvd")]
        public void TestandoCriarUmDvd_DepoisPegarEmprestado()
        {
            //Arrange
            var emprestimoServicoMock = new Mock<IEmprestimoServico>();

            DvdRequest dvd = new()
            {
                Genero = ColecaoLivrosCDsDVDs.Enum.Genero.Ficçao,
                Nome = "Harry Potter",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel
            };
            var dvdParaPegar = new DVD(dvd);

            //Act
            emprestimoServicoMock.Setup(x => x.EfetuarEmprestimoDvd(dvdParaPegar.Id)).Returns(true);

            ////Assert
            Assert.True(emprestimoServicoMock.Object.EfetuarEmprestimoDvd(dvdParaPegar.Id));
        }

        [Fact(DisplayName = "Deveria excluir um Livro")]
        public void TestandoExcluirUmLivroApenasUmaVez()
        {
            //Arrange
            var livroServicoMock = new Mock<ILivroServico>();
            var livroController = new LivroController(livroServicoMock.Object);

            LivroRequest livro = new()
            {
                Autor = "A História de Machado de Assis",
                Genero = ColecaoLivrosCDsDVDs.Enum.Genero.Romance,
                Nome = "Machado de Assis",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel
            };
            var livroParaExcluir = new Livro(livro);

            //Act
            var result = livroController.ExcluirLivro(livroParaExcluir.Id);

            ////Assert
            livroServicoMock.Verify(x => x.Excluir(livroParaExcluir.Id), Times.Exactly(1));
        }

        [Fact(DisplayName = "Deveria excluir um Cd")]
        public void TestandoExcluirUmCd()
        {
            //Arrange
            var cdServicoMock = new Mock<ICdServico>();
            var cdController = new CdController(cdServicoMock.Object);

            CdRequest cd = new()
            {
                Nome = "Prainha",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel,
                GeneroMusical = ColecaoLivrosCDsDVDs.Enum.GeneroMusical.Axe,
                Cantor = "Leo Santana"
            };
            var cdParaExcluir = new CD(cd);

            //Act
            var result = cdController.ExcluirCd(cdParaExcluir.Id);

            ////Assert
            cdServicoMock.Verify(x => x.Excluir(cdParaExcluir.Id), Times.Exactly(1));
        }

        [Fact(DisplayName = "Deveria excluir um Dvd")]
        public void TestandoExcluirUmDvd()
        {
            //Arrange
            var dvdServicoMock = new Mock<IDvdServico>();

            DvdRequest dvd = new()
            {
                Nome = " O chamado",
                Status = ColecaoLivrosCDsDVDs.Enum.Status.Disponivel,
                Genero = ColecaoLivrosCDsDVDs.Enum.Genero.Terror
            };
            var dvdParaExcluir = new DVD(dvd);

            //Act
            dvdServicoMock.Setup(x => x.Excluir(dvdParaExcluir.Id)).Returns(true);

            ////Assert
            Assert.True(dvdServicoMock.Object.Excluir(dvdParaExcluir.Id));
        }
    }
}
