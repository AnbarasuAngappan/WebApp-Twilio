https://docs.microsoft.com/en-us/aspnet/mvc/overview/security/aspnet-mvc-5-app-with-sms-and-email-two-factor-authentication

https://www.twilio.com/console

anbarasu.intellibot@gmail.com
tomjerrysai27@Anbu



(734) 526-6121
+17345266121

-------------------------------------------------

using System; 
using System.Collections.Generic; 
using Twilio; 
using Twilio.Rest.Api.V2010.Account; 
using Twilio.Types; 
 
class Example 
{ 
    static void Main(string[] args) 
    { 
        var accountSid = "ACa8574533b3e522f0137793cf2460c87d"; 
        var authToken = "[AuthToken]"; 
        TwilioClient.Init(accountSid, authToken); 
 
        var messageOptions = new CreateMessageOptions( 
            new PhoneNumber("+919600688497")); 
        messageOptions.From = new PhoneNumber("+17345266121");    
        messageOptions.Body = "HI Heloooo secind";   
 
        var message = MessageResource.Create(messageOptions); 
        Console.WriteLine(message.Body); 
    } 
}