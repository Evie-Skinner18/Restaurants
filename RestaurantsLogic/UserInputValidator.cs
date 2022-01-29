namespace RestaurantsLogic;

using System.Text.RegularExpressions;

public static class UserInputValidator
{
    public static bool ValidateUkPostcode(string postcode)
    {
        bool isValid = false;

        Regex ukPostcodeRegex = new(@"^(GIR 0AA)|[a-z-[qvx]](?:\d|\d{2}|[a-z-[qvx]]\d|[a-z-[qvx]]\d[a-z-[qvx]]|[a-z-[qvx]]\d{2})(?:\s?\d[a-z-[qvx]]{2})?$"); 

        if (ukPostcodeRegex.IsMatch(postcode))
        {
            isValid = true;
        }

        return isValid;
    }
}