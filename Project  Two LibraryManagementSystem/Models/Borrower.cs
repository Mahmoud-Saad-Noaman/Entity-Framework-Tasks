using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__Two_LibraryManagementSystem.Models
{
    public class Borrower
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime MembershipDate { get; set; }

        public ICollection<Loan> Loans { get; set; }
        #endregion
    }
}
