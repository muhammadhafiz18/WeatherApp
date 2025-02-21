
const string KEY = "3fe3618da3f5d90fb993d05aa32c0afc";
Console.WriteLine("Please enter the city name: ");
string city = Console.ReadLine();

using (HttpClient client = new())
{
    try 
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={KEY}";
        HttpResponseMessage response = await client.GetAsync(url);


        if(response.IsSuccessStatusCode)
        {
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);        
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exception: {ex.Message}");
    }
}


