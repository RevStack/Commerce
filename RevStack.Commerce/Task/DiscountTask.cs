using System;
using System.Collections.Generic;
using System.Linq;

namespace RevStack.Commerce
{
   
    #region "Discount Task Base Class"
    public class DiscountTask : IDiscountTask<string>
    {
        public virtual RuleType RuleType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual DiscountType Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual IShoppingBag<string> Run(IShoppingBag<string> bag, IEnumerable<IDiscount> discounts, string code)
        {
            throw new NotImplementedException();
        }

        public virtual Tuple<bool, string> Validate(IShoppingBag<string> bag, IDiscount discount)
        {
            return validate(bag, discount);
        }

        protected Tuple<bool, string> validate(IShoppingBag<string> bag, IDiscount discount)
        {
            if (discount == null)
            {
                return new Tuple<bool, string>(false, Settings.PromotionInvalidMessage);
            }
            else
            {
                if (discount.Expires && discount.ExpirationDate < DateTime.Now)
                {
                    return new Tuple<bool, string>(false, "The " + Settings.PromotionLabel + " code has expired");
                }
                else if (discount.MinValue != null && discount.MinValue > bag.Subtotal)
                {
                    return new Tuple<bool, string>(false, "The " + Settings.PromotionLabel + " code requires a min purchase amount of " + Convert.ToDecimal(discount.MinValue).ToString("C"));
                }
                else if (bag.DiscountItems.Where(x => x.Code.ToLower() == discount.Code.ToLower()).Any())
                {
                    return new Tuple<bool, string>(false, "The " + Settings.PromotionLabel + "  code has already been added");
                }
                else
                {
                    return new Tuple<bool, string>(true, "");
                }
            }
        }
    }

    #endregion

    
}