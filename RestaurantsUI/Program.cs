using RestaurantsLogic;

Console.WriteLine($"Hello and welcome to the restaurant searcher");

HttpClient apiClient = new();
string baseUri = @"https://uk.api.just-eat.io";
RestaurantService restaurantService = new(apiClient, baseUri);

List<Restaurant> localRestaurantsOpenNow = await restaurantService.GetLocalRestaurants("gl55bp");

Console.WriteLine("Local restaurants open now:");

foreach(var restaurant in localRestaurantsOpenNow)
    Console.WriteLine($"{restaurant.Name}");
