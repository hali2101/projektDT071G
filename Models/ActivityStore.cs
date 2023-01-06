using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace projectpractice.Models
{
	public class ActivityStore
	{
		//sparar filnamnet i en variabel
		private string filename = @"/Users/hannalindholm/Projects/projectdt071g/projectpractice/bin/Debug/net7.0-maccatalyst/maccatalyst-x64/projectpractice.appactivitystore.json";

        //skapar en ny lista
        private List<Activity> activities = new List<Activity>();

        //kontrollerar om filen existerar och deserialiserar
        public ActivityStore()
        {
            if (File.Exists(@"/Users/hannalindholm/Projects/projectdt071g/projectpractice/bin/Debug/net7.0-maccatalyst/maccatalyst-x64/projectpractice.appactivitystore.json") == true)
            {
                string jsonString = File.ReadAllText(filename);
                //deserialiserar json-filen
                activities = JsonSerializer.Deserialize<List<Activity>>(jsonString)!;
            }
        }

        //returnerar alla aktiviteter i listan
        public List<Activity> GetActivities()
        {
            return activities;
        }

        //metod för att serialisera data till jsonfilen
        public Activity Storedata(Activity activity)
        {
            //skapar ny tom lista för påfyllnad med nya uppgifter
            activities = new List<Activity>();
            activities.Add(activity);

            // serialiserar och skriver till json-filen
            var jsonString = JsonSerializer.Serialize(activities);
            File.WriteAllText(filename, jsonString);

            return activity;
        }

    }
}

