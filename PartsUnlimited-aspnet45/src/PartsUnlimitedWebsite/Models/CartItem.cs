using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
<<<<<<< HEAD
    //Comment to test commit into repo1
=======
>>>>>>> b5eaa596236a12599bdc1c7575f66fdd1d9991ba
    public class CartItem : ILineItem
    {
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}