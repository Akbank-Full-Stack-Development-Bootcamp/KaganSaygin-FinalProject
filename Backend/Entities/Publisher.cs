using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Publisher : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        //public virtual IList<Book> Books { get; set; }
    }
}