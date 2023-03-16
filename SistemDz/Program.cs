HttpClient http = new();
http.BaseAddress = new("https://google-translate1.p.rapidapi.com/language/translate/v2/detect"); ;
var t = await http.GetAsync(http.BaseAddress);
