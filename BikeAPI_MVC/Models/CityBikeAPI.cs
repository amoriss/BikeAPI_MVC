using Newtonsoft.Json;

namespace BikeAPI_MVC.Models;

public class CityBikeAPI
{
    public static List<Network> CallAPI()
    {
        HttpClient client = new HttpClient(); //client

        string apiUrl = "http://api.citybik.es/v2/networks"; //endpoint

        string jsonResponse = client.GetStringAsync(apiUrl).Result; //calling endpoint with client

        Root networksResponse = JsonConvert.DeserializeObject<Root>(jsonResponse); //converting string into object

        return networksResponse.Networks;

    }
}
