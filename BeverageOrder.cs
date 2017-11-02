using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntraCoffee.Domain.Model
{
    public class BeverageOrder:IEntity
    {
        private ICollection<Condiment> _condiments;

        public BeverageOrder()
        {
            _condiments=new HashSet<Condiment>();
        }

        [Key]
        public long Id { get; set; }

        public long BeveragePriceId { get; set; }

        [ForeignKey("BeveragePriceId"), Required]
        public virtual BeveragePrice BeveragePrice { get; set; }
        
        [ForeignKey("OrderId"), Required]
        public virtual Order Order { get; set; }

        public long OrderId { get; set; }

        public virtual ICollection<Condiment> Condiments
        {
            get { return _condiments; }
            set { _condiments = value; }
        }
    }
}
