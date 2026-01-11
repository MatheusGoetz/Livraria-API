using Livraria.Comunication.Requests;
using Livraria.Comunication.Responses;

namespace Livraria.Application.UseCases.Livros.AdicionarLivro;

public class AdicionarLivroUseCase
{
    public ResponseCreatedJson Execute(RequestLivroJson request)
    {
        return new ResponseCreatedJson
        {
            Id = 1,
            Name = request.Titulo,
            CreatedAt = DateTime.UtcNow
        };
    }
}
