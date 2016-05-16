using System;
using System.Text;
using System.Text.RegularExpressions;
using RevStack.Mvc;

namespace RevStack.Commerce
{
    public static class CreditCard
    {
        public static bool IsValidNumber(string cardNumber)
        {
            int i, checkSum = 0;

            // Compute checksum of every other digit starting from right-most digit
            for (i = cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (cardNumber[i] - '0');

            // Now take digits not included in first checksum, multiple by two,
            // and compute checksum of resulting digits
            for (i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            // Number is valid if sum of both checksums MOD 10 equals 0
            return ((checkSum % 10) == 0);
        }
        public static string NormalizeCardNumber(string cardNumber)
        {
            if (cardNumber == null)
                cardNumber = String.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (char c in cardNumber)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }

            return sb.ToString();
        }

        public static CreditCardType CardType(string cardNumber)
        {
            foreach (CardTypeInfo info in cardTypeInfo)
            {
                if (cardNumber.Length == info.Length && Regex.IsMatch(cardNumber, info.RegEx))
                    return info.Type;
            }
            return CreditCardType.Unknown;
        }

        public static string Encode(string cardnumber)
        {
            var length = cardnumber.Length;
            cardnumber.Replace("-", "");
            string cardPrefix = cardPrefixString(length);
            string last4Digits = cardnumber.LastChars(4);
            return cardPrefix + last4Digits;
        }



        #region "private"
        private static string cardPrefixString(int length)
        {
            string bankString = "xxxx-xxxx-xxxx-";
            string amexString = "xxxx-xxxxxx-x";
            string cardString = "xxxx-xxxxxx-";
            if (length == 16) return bankString;
            else if (length == 15) return amexString;
            else return cardString;
        }

        private class CardTypeInfo
        {
            public CardTypeInfo(string regEx, int length, CreditCardType type)
            {
                RegEx = regEx;
                Length = length;
                Type = type;
            }

            public string RegEx { get; set; }
            public int Length { get; set; }
            public CreditCardType Type { get; set; }
        }

        private static CardTypeInfo[] cardTypeInfo =
        {
            new CardTypeInfo("^(51|52|53|54|55)", 16, CreditCardType.MasterCard),
            new CardTypeInfo("^(4)", 16, CreditCardType.VISA),
            new CardTypeInfo("^(4)", 13, CreditCardType.VISA),
            new CardTypeInfo("^(34|37)", 15, CreditCardType.Amex),
            new CardTypeInfo("^(6011)", 16, CreditCardType.Discover),
            new CardTypeInfo("^(300|301|302|303|304|305|36|38)", 14, CreditCardType.DinersClub),
            new CardTypeInfo("^(3)", 16, CreditCardType.JCB),
            new CardTypeInfo("^(2131|1800)", 15, CreditCardType.JCB),
            new CardTypeInfo("^(2014|2149)", 15, CreditCardType.enRoute)
        };

        #endregion
    }
}
