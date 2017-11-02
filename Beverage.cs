using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IntraCoffee.Domain.Model
{
    /// <summary>
    /// Напиток
    /// </summary>
    public  class Beverage : IEntity
    {
        private ICollection<BeveragePrice> _beveragePrices;

        public Beverage()
        {
            _beveragePrices = new HashSet<BeveragePrice>();
        }

        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [Required]
        public string Name { get; set; }

        public virtual ICollection<BeveragePrice> BeveragePrices
        {
            get { return _beveragePrices; }
            set { _beveragePrices = value; }
        }

        /// <summary>
        /// Описание
        /// </summary>
        [Required]
        public string Description { get; set; }

        [Required]
        public virtual byte[] Image { get; set; }

        [Required]
        public virtual byte[] ThumbnailImage { get; set; }

        [Required]
        public string Composition { get; set; }

        [Required]
        public bool IsArchive { get; set; }
    }
}
