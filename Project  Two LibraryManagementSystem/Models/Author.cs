using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__Two_LibraryManagementSystem.Models
{
    public class Author
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public ICollection<Book> Books { get; set; }
        #endregion
    }
}
