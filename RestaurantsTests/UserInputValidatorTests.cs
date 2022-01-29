
namespace RestaurantsTests;

using NUnit.Framework;
using RestaurantsLogic;
using System.Net.Http;

public class UserInputValidatorTests
{

    [Test]
    public void ValidateUkPostcode_WhenTheGivenPostcodeIsgl102na_ShouldReturnTrue()
    {
        bool isValid = UserInputValidator.ValidateUkPostcode("gl102na");

        Assert.IsTrue(isValid);
    }

    [Test]
    public void ValidateUkPostcode_WhenTheGivenPostcodeIsxxx_ShouldReturnFalse()
    {
        bool isValid = UserInputValidator.ValidateUkPostcode("xxx");

        Assert.IsFalse(isValid);
    }
}