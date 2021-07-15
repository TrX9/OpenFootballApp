using System;
using System.Collections.Generic;

namespace api_football
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Parameters
    {
        public string country { get; set; }
    }

    public class Paging
    {
        public int current { get; set; }
        public int total { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string founded { get; set; }
        public bool national { get; set; }
        public string logo { get; set; }
    }

    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string capacity { get; set; }
        public string surface { get; set; }
        public string image { get; set; }
    }

    public class Response
    {
        public Team team { get; set; }
        public Venue venue { get; set; }
    }

    public class Root
    {
        public string get { get; set; }
        public Parameters parameters { get; set; }
        public List<object> errors { get; set; }
        public int results { get; set; }
        public Paging paging { get; set; }
        public List<Response> response { get; set; }
    }


}
