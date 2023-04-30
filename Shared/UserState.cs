using System;
namespace client.Shared
{
    // class adapted from json2csharp.com
    // UserState myDeserializedClass = JsonConvert.DeserializeObject<UserState>(myJsonResponse);
    public class UserState
    {
        public static bool is_logged_in { get; set; } = false;
        public static int id { get; set; }
        public static string first_name { get; set; }
        public static string last_name { get; set; }
        public static string email_address { get; set; }
        public static string apiKey { get; set; }
        public static bool is_admin { get; set; }
        public static DateTime created_at { get; set; }
        public static int portfolio { get; set; }

        public override string ToString()
        {
            return $"{first_name} {last_name}, id {id} email {email_address}";
        }
            
    }
}

