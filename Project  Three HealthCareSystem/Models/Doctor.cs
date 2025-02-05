using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__Three_HealthCareSystem.Models
{
    public class Doctor
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Specialization { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

        #endregion
    }
}
