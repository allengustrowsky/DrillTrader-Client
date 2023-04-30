using System;
namespace client.Data
{
    // This definition adapted from json2csharp.com
    // SignUpResponse myDeserializedClass = JsonConvert.DeserializeObject<SignUpResponse>(myJsonResponse);
    public class SignUpResponse
    {
        public int id { get; set; }
        public string apiKey { get; set; }
        public bool is_admin { get; set; }
        public DateTime created_at { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
        public Portfolio portfolio { get; set; }
    }
}

