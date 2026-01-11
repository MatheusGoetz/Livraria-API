namespace Livraria.Comunication.Responses;

public class ResponseLivrosJson
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public DateTime updatedAt { get; set; }
}
