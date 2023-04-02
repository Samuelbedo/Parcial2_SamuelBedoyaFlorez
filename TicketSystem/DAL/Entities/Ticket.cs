using System.ComponentModel.DataAnnotations;

namespace TicketSystem.DAL.Entities
{
    public class Ticket
    {
        #region Properties
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Display (Name = "Fecha de uso de la boleta")]
        public DateTime? UseDate { get; set; }
        [Display (Name = "Boleta redimida")]
        public bool IsUsed{ get; set; }
        [Display (Name = "Puerta de entrada")]
        public string? EntranceGate{ get; set; }


        #endregion
    }
}
