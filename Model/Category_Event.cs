using API.RESERVAS.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPelicula.Model
{
    public class Category_Event
    {
        [Key]
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

    }
}
