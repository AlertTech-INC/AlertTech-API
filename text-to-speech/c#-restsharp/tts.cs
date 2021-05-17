var client = new RestClient("https://demo.alerttech.cloud/api/v1/tts");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("api_key", "dev");
request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
request.AddParameter("location_id", "12345");
request.AddParameter("tts", "This is a TTS string.");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);