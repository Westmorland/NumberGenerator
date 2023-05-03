using System.Net.Http.Json;

namespace DaprExampleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            // Generate a random number using the number-generator service
            var numberResponse = await client.GetAsync("http://localhost:3500/v1.0/invoke/numbergenerator/method/numbergenerator/generate");
            int number = await numberResponse.Content.ReadFromJsonAsync<int>();

            // Square the number using the squaring-service
            var squareResponse = await client.PostAsJsonAsync("http://localhost:3500/v1.0/invoke/squaringservice/method/SquaringService/square", number);
            int square = await squareResponse.Content.ReadFromJsonAsync<int>();

            // Save the number and its square using Dapr's state management
            var stateData = new[]
            {
                new { key = "number", value = number },
                new { key = "square", value = square }
            };

            await client.PostAsJsonAsync("http://localhost:3500/v1.0/state/statestore", stateData);

            Console.WriteLine($"Number: {number}, Square: {square}");
        }
    }
}
