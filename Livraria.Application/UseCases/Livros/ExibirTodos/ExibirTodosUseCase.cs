using Livraria.Comunication.Responses;

namespace Livraria.Application.UseCases.Livros.ExibirTodos;

public class ExibirTodosUseCase
{
    public ResponseAllLivrosJson Execute()
    {
        return new ResponseAllLivrosJson
        {
            Livros = new List<ResponseShortLivrosJson>
            {
                new ResponseShortLivrosJson
                {
                    Id = 1, 
                    Titulo = "O Senhor dos Anéis",
                    Autor = "J.R.R. Tolkien",
                    Genero = "Fantasia",
                    Preco = 59.90,
                    Estoque = 10
                }
            }
        };
    }
}
