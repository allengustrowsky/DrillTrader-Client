using System;
namespace client.Data
{
    // This definition adapted from json2csharp.com
    // User myDeserializedClass = JsonConvert.DeserializeObject<User>(myJsonResponse);
    public class User
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
    }

    //public class User
    //{
    //	//public User()
    //	//{

    //	//}
    //       public string? first_name;
    //       public string? last_name;
    //       public string? email_address;

    //       //public override string ToString()
    //       //{
    //       //    return $"{first_name} {last_name}: {email_address}";
    //       //}
    //   }
}

