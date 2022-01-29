namespace RestaurantsLogic;

public interface IRestaurantService
{
    string CreateRequestUri();
    List<Restaurant> GetLocalRestaurants(string postcode);
}