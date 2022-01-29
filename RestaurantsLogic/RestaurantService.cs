namespace RestaurantsLogic;

using Newtonsoft.Json;

public class RestaurantService
{
    public RestaurantService(HttpClient httpClient, string baseUri)
    {
        _httpClient = httpClient;
        _baseUri = baseUri;
    }

    private HttpClient _httpClient {get; set;}
    private string _baseUri { get; set; }

    public async Task<List<Restaurant>> GetLocalRestaurants(string postcode)
    {
        postcode = postcode.Trim();
        
        string requestUri = CreateRequestUri(postcode);
        HttpResponseMessage apiResponse = await CallApi(requestUri);

        string jsonContent = await GetResponseData(apiResponse);
        List<Restaurant> allLocalRestaurants = DeserialiseJsonResponse(jsonContent);

        List<Restaurant> allLocalRestaurantsCurrentlyOpen = FilterRestaurants(allLocalRestaurants, r => r.IsOpenNow);

        return allLocalRestaurantsCurrentlyOpen;
    }

    public string CreateRequestUri(string postcode)
    {
        return $"{_baseUri}/restaurants/bypostcode/{postcode}";
    }

    public async Task<HttpResponseMessage> CallApi(string requestUri)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(requestUri);

        return response;
    }

    public async Task<string> GetResponseData(HttpResponseMessage apiResponse)
    {
        if (apiResponse.IsSuccessStatusCode)
            {
                string jsonContent = await apiResponse.Content.ReadAsStringAsync();
                return jsonContent;
            }

            else
            {
                throw new Exception($"The API at {_baseUri} returned a {apiResponse.StatusCode} response! Oh no!");
            }
    }

    public List<Restaurant> DeserialiseJsonResponse(string jsonContent)
    {
        List<Restaurant> restaurants = new();
        RestaurantSearchResponse restaurantSearchResponse = JsonConvert.DeserializeObject<RestaurantSearchResponse>(jsonContent);

        if (restaurantSearchResponse != null)
        {
            restaurants = restaurantSearchResponse.Restaurants;
        }

        return restaurants;
    }

    public List<Restaurant> FilterRestaurants(List<Restaurant> restaurants, Func<Restaurant, bool> predicate)
    {
        return restaurants.Where(predicate).ToList();
    }
}