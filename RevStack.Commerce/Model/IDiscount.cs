using System;
using System.Collections.Generic;
using RevStack.Pattern;

namespace RevStack.Commerce
{
    public interface IDiscount : IEntity<string>
    {
        string Code { get; set; }
        string Description { get; set; }
        RuleType RuleType { get; set; }
        DiscountType Type { get; set; }
        string CustomIdentifier { get; set; }
        decimal? MinValue { get; set; }
        decimal Amount { get; set; }
        decimal Percentage { get; set; }
        IEnumerable<string> Skus { get; set; }
        bool Expires { get; set; }
        DateTime ExpirationDate { get; set; }
        DateTime CreatedDate { get; set; }
    }
}