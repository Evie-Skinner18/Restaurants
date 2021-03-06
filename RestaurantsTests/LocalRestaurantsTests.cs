
namespace RestaurantsTests;

using NUnit.Framework;
using RestaurantsLogic;
using System.Net.Http;

public class LocalRestaurantsTests
{

    [Test]
    public void CreateRequestUri_WhenTheGivenPostcodeIsgl102na_ShouldCreateAStringSoecifyinggl102naAsThePostcodeParameter()
    {
        HttpClient apiClient = new();
        string baseUri = @"https://uk.api.just-eat.io";
        string stroudPostcode = "gl102na";

        RestaurantService restaurantService = new(apiClient, baseUri);

        string stroudRequestUri = restaurantService.CreateRequestUri(stroudPostcode);

        Assert.AreEqual("https://uk.api.just-eat.io/restaurants/bypostcode/gl102na", stroudRequestUri);
    }
}