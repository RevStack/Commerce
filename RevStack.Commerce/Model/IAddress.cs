using System;


namespace RevStack.Commerce
{
    public interface IAddress
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string PhoneNumber2 { get; set; }
        string Street { get; set; }
        string Street2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
    }
}