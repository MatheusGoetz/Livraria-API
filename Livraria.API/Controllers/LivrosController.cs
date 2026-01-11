using Livraria.Application.UseCases.Livros.AdicionarLivro;
using Livraria.Application.UseCases.Livros.AtualizarLivro;
using Livraria.Application.UseCases.Livros.DeletarLivro;
using Livraria.Application.UseCases.Livros.ExibirLivroId;
using Livraria.Application.UseCases.Livros.ExibirTodos;
using Livraria.Comunication.Requests;
using Livraria.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivrosController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult AdicionarLivro([FromBody] RequestLivroJson request)
    {
        var useCase = new AdicionarLivroUseCase().Execute(request);

        return Created(string.Empty, useCase);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult AtualizarLivro([FromRoute] int id, [FromBody] RequestLivroJson request)
    {
        var useCase = new AtualizarLivroUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllLivrosJson),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ExibirTodos()
    {
        var useCase = new ExibirTodosUseCase();

        var response = useCase.Execute();

        if (response.Livros.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseLivrosJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult ExibirLivro(int id)
    {
        var useCase = new ExibirLivroIdUseCase();

        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Deletar(int id)
    {
        var useCase = new DeletarLivroUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}