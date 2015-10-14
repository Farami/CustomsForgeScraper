# CustomsForgeScraper
A simple C# library to log in and search for songs on CustomsForge.com

Happy to accept improvements/changes, just make a pull request.

#Quick Example
```C#
using CustomScraper;
using CustomScraper.Model;

// Log in with someUsername, somePassword
ScrapeClient client = ScrapeClient.CreateInstance("someUsername", "somePassword");
// Look up "metallica"
List<Song> searchResults = client.Lookup("metallica").Results;
```

There's not too much more to it than that, an example project is included.

#Notes
Logging in is particularly slow - logging in requires a token from the login page. Getting the token and hitting the login page (across potentially slow servers...) is no fun. ಠ╭╮ಠ

Once logged in it will be fast unless:
* CustomsForge is running slow
* Your hardware sucks
* Your internet sucks
* Any other excuse that doesn't deal with muh code ♥

Open to questions etc. so please feel free to ask.
