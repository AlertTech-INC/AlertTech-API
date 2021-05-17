require "uri"
require "net/http"

url = URI("https://demo.alerttech.cloud/api/v1/tts")

https = Net::HTTP.new(url.host, url.port)
https.use_ssl = true

request = Net::HTTP::Post.new(url)
request["api_key"] = "dev"
request["Content-Type"] = "application/x-www-form-urlencoded"
request.body = "location_id=12345&tts=This%20is%20a%20TTS%20string."

response = https.request(request)
puts response.read_body