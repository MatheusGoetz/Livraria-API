using Livraria.Comunication.Responses;

namespace Livraria.Application.UseCases.Livros.ExibirLivroId;

public class ExibirLivroIdUseCase
{
    public ResponseLivrosJson Execute(int id)
    {
        return new ResponseLivrosJson
        {
            Id = id,
            Titulo = "O Senhor dos Anéis",
            Autor = "J.R.R. Tolkien",
            Genero = "Fantasia",
            Preco = 59.90,
            Estoque = 10,
        };
    }
}
