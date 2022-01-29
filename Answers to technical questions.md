
*1. How long did you spend on the coding test? What would you add to your solution if you had more time? If you didn't spend much time on the coding test then use this as an opportunity to explain what you would add*

I spent 3h on the test. If I'd had more time, I would have renamed 'Class1.cs' containing the C# models of the API response DTOs to 'RestaurantSearchResponse.cs'. I would have also spent some time refactoring my solution to make it more flexible, and I would have added more unit tests. Furthermore, I would have added a makefile to abstract away the layer of the .Net CLI commands from the user so they can run it using a more human-friendly command. If I had lots more time, I would have made the application as a Vue 3 SPA instead, but I wanted to keep it simple because of the point in the instructions that mentioned calls directly from the browser will fail. I would have liked to investigate a way around this problem because I love Vue!

*2. What was the most useful feature that was added to the latest version of your chosen language? Please include a snippet of code that shows how you've used it.*

The most useful feature of C#10 for me was the new syntax for instantiating an object.
``` C#
Program.cs:

    RestaurantService restaurantService = new(apiClient, baseUri);
```
I found it useful because it allowed me to create new objects more quickly. I also really like the new simplified look of C#, particularly the removal of the Main() method and lots of extra curly braces that used to be a bit of a nightmare!

*3. How would you track down a performance issue in production? Have you ever had to do this?*

I would search the error logs in Azure/AWS for the resource that I suspect is causing the performance issue. I would look for a timeout error or a 500 server error. I have never had to do this yet, but I have fixed a bug that came into my team's sprint as a result of such an issue.


*4. How would you improve the Just Eat APIs that you just used?*

 I would consider separating some of the objects nested in the RestaurantSearchResponse object. This is because the whole object was huge, making it difficult for a client application to consume and difficult for a human to reason about. I would separate some of the metadata into a different endpoint or remove some of it all toghether, since I found some duplication (the MetaData object contains some address fields, yet there is an Address object inside each Restaurant object).