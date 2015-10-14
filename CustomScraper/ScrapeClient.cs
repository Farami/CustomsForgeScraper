using CustomScraper.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
namespace CustomScraper
{
    public class ScrapeClient
    {
        protected HttpClient client;
        private string _username;
        private string _password;

        public ScrapeClient(string username, string password)
        {
            this._username = username;
            this._password = password;
            client = new HttpClient();
            Login();
        }

        #region Login
        protected void Login()
        {
            var loginData = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string, string>("ips_username", _username),
                new KeyValuePair<string, string>("ips_password", _password),
                new KeyValuePair<string, string>("auth_key", GetAuthKey()),
                new KeyValuePair<string, string>("rememberMe", "1")
            });
            var res = client.PostAsync("http://customsforge.com/index.php?app=core&module=global&section=login&do=process", loginData);
            res.Result.EnsureSuccessStatusCode();
        }

        protected string GetAuthKey()
        {
            var html = client.GetStringAsync("http://customsforge.com/index.php?app=core&module=global&section=login");
            var dom = new HtmlAgilityPack.HtmlDocument();
            dom.LoadHtml(html.Result);

            var authNode = dom
                .DocumentNode
                .Descendants("input")
                .Where(n => n.Attributes["name"] != null && n.Attributes["name"].Value == "auth_key").FirstOrDefault();

            if (authNode == null)
            {
                return "";
            }
            Console.WriteLine("Auth key retrieved");
            return authNode.GetAttributeValue("value", "");
        }
        #endregion

        public SongRequest Lookup(string search)
        {
            var result = new SongRequest();
            string json = RequestJson(search);
            dynamic data = JObject.Parse(json);

            if(data.data.Count == 0)
            {
                result.Error = true;
                result.ErrorType = SongRequest.RequestError.NoResults;
            }
            else if(data.data.Count > 5)
            {
                result.Error = true;
                result.ErrorType = SongRequest.RequestError.TooManyResults;
            }
            else
            {
                foreach(dynamic song in data.data)
                {
                    result.Results.Add(ParseSong(song));
                }
            }

            return result;
        }

        protected string RequestJson(string search, bool relog = false)
        {
            var res = client.PostAsync("http://ignition.customsforge.com/cfss?u=21575", FormData.GetFormData(search)).Result;
            if (res.RequestMessage != null && res.RequestMessage.RequestUri.ToString().Contains("section=login"))
            {
                if(relog)
                {
                    throw new Exception("Failed to log in, breaking endless loop.");
                }
                Login();
                return RequestJson(search, true);
            }
            return res.Content.ReadAsStringAsync().Result;
        }

        protected Song ParseSong(dynamic json)
        {
            var song = new Song()
            {
                CFId = json[0],
                Artist = json[1],
                Title = json[2],
                Tuning = json[4],
                Lead = json[10].ToString().Contains("lead"),
                Rhythm = json[10].ToString().Contains("rhythm"),
                Bass = json[10].ToString().Contains("bass"),
                Official = json[15]
            };
            return song;
        }
    }
}
