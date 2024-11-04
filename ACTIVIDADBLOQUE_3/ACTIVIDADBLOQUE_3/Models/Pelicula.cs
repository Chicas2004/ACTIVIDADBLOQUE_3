using System.ComponentModel.DataAnnotations;

namespace ACTIVIDADBLOQUE_3.Models 
{ 
    public class Pelicula
    {
    [Key]
    public int idPelicula { get; set; }
    public string titulo { get; set; }
    public string autor { get; set; }
    public string sinopsis { get; set; }
    public int duracion { get; set; }
    public string clasificacion { get; set; }
    }

    }

