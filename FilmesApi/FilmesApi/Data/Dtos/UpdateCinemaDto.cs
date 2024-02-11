using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateCinemaDto
{

    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Titulo { get; set; }

}
