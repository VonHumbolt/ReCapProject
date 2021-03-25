using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CardInfo : IEntity
    {
        [Key]
        public int CardId { get; set; }

        public String CardNumber { get; set; }

        public decimal Price { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
