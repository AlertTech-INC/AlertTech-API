var settings = {
    "url": "https://demo.alerttech.cloud/api/v1/tts",
    "method": "POST",
    "timeout": 0,
    "headers": {
      "api_key": "dev",
      "Content-Type": "application/x-www-form-urlencoded"
    },
    "data": {
      "location_id": "12345",
      "tts": "This is a TTS string."
    }
  };
  
  $.ajax(settings).done(function (response) {
    console.log(response);
  });