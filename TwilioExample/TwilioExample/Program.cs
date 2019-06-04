using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Twilio;
using Twilio.Converters;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML.Messaging;

namespace TwilioExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC0304ad36c38889f66df5992efdfa708d";
            const string authToken = "3410bf61b3d6215e5ba511b42bb39704";

            TwilioClient.Init(accountSid, authToken);


            var message = MessageResource.Create(
                body: "Prueba completada",
                from: new Twilio.Types.PhoneNumber("+17205131645"),
                to: new Twilio.Types.PhoneNumber("+50671022752")
            );

            Console.WriteLine(message.Sid);
            Console.ReadLine();
        }
    }
}
