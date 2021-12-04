# Tune Tip UI

We utilized Blazor to build out our web UI because it utilizes C# and the team's understanding of Java/C# as opposed to JavaScript. We have built out our UI constructing web pages and implementing reusuable UI components we have either sourced from a library like Blazorise or built ourselves with HTML and CSS. For more information on Blazor and building out razor components please follow this [link](https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-6.0).

## Prerequisites

Before running and utilizing Tune Tip UI, you need to have both music service and recommendation service running on your machine. The UI is set to make API requests to both those services and you won't be able to go very far without them. For the music-service you need to also be running the database in Docker to retrieve the data and utize the account/recommendation section of the UI.

## Running Tune Tip UI

Running the user interface is very straight forward, you should be on a current .NET framework. We utilize .NET 5 for our application and the required NuGet packages installed in our solution are compatible with that framwork. Simply set MusicRecommendation.App as the startup project and run the application to pull up the UI. The application should successfully launch and you should be directed to the Tune Tip home page being hosted at: `http://localhost:3000/`.

For a detailed demo of how to run Tune Tip and navigating through the UI please refer to this demo video [here](https://www.youtube.com/watch?v=LAy3bJiqh2k).

## Dependencies

We are currently utilizing Blazorise for a few components:

- Data grid
- Loader/spinner

Other than those listed above we are utilizing html and css to build out and design our user interface for Tune Tip.
