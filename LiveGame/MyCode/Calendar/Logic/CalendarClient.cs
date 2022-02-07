using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using LiveGame.MyCode.Calendar.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LiveGame.MyCode.Calendar.Logic
{
    public class CalendarClient
    {
        protected UserCredential credential;
        protected CalendarService service;

        public CalendarClient()
        {
            string path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Klucze\KalendarzGoogle\client_secret.json";

            string json = System.IO.File.ReadAllText(path);
            var key = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelCalendarJsonKey>(json);


            ClientSecrets clientSecrets = new ClientSecrets
            {
                ClientId = key.installed.client_id,
                ClientSecret = key.installed.client_secret,
            };

            string[] scopes = new[] { CalendarService.Scope.Calendar };
            string user = "user";

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(clientSecrets, scopes, user, CancellationToken.None).Result;

            BaseClientService.Initializer initializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "Calendar API Sample",
            };

            service = new CalendarService(initializer);
        }
    }
}
