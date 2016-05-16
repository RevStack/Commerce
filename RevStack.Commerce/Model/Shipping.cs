using System;
using RevStack.Pattern;

namespace RevStack.Commerce
{
    public class ShippingAddress : Address { }

    public class ShippingMethod : IEntity<string>
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public decimal Charge { get; set; }
        public bool Checked { get; set; }
        public ShippingMethod()
        {
            Checked = false;
        }
    }
}