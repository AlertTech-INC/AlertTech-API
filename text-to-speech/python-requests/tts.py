import requests

url = "https://demo.alerttech.cloud/api/v1/tts"

payload='location_id=12345&tts=This%20is%20a%20TTS%20string.'
headers = {
  'api_key': 'dev',
  'Content-Type': 'application/x-www-form-urlencoded'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)