using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RevStack.Mvc;

namespace RevStack.Commerce
{
   
    public class Discount : IDiscount
    {
        public string Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
        [SelectRequired]
        [Display(Name = "Rule Type")]
        public RuleType RuleType { get; set; }
        [SelectRequired]
        [Display(Name = "Discount Type")]
        public DiscountType Type { get; set; }
        public string CustomIdentifier { get; set; }
        public decimal? MinValue { get; set; }
        public decimal Amount { get; set; }
        public decimal Percentage { get; set; }
        public IEnumerable<string> Skus { get; set; }
        public bool Expires { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public Discount()
        {
            Id = Guid.NewGuid().ToString();
            Skus = new List<string>();
            CreatedDate = DateTime.Now;
            CustomIdentifier = null;
            Percentage = 0;
            Expires = false;
            ExpirationDate = DateTime.Now.AddYears(10);
            Description = null;
        }
    }

    public class DiscountItem
    {
        public string Id { get; set; }
        public RuleType RuleType { get; set; }
        public DiscountType Type { get; set; }
        public string CustomIdentifier { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public decimal Total { get; set; }

        public DiscountItem()
        {
            Id = Guid.NewGuid().ToString();
        }
    }


    public enum RuleType
    {
        Subtotal,
        Item,
        Shipping,
        Custom,
        Validation
    }

    public enum DiscountType
    {
        DollarDiscount,
        PercentageDiscount,
        Custom,
        Purge
    }
}