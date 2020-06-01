using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO.Compression;
using WebPush;

namespace WebPushDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class WebPushController : Controller
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public ActionResult<string> enviar(string pushEndpoint, string p256dh, string auth)
        {
            var keys = VapidHelper.GenerateVapidKeys();

            // "eC8kA5lfrjc:APA91bHHHh3ikNWPa-614pz7FbWdPvCTn01OvkNuas6m-ilwP-U_VPHLd5QPsjL8W5G8gLquoTJd-jUVRDOziyXvxXoeY8ua2sRvt6GnG8WLpFdOkk7SI8_AxFZnlug4t9FOU7S-XjzH"
            pushEndpoint = @"https://fcm.googleapis.com/fcm/send/" + pushEndpoint;
            //p256dh = @"BAGGIn3MC7LZRCFKuRRSjA28bwQRP7mO_9AEr2l7ety-dtSn7Fcw11-aZu5UCOE0C2gVXVEaWkFLu7PWCR1ufGI";
            //auth = @"VKMl5N1lJomQreFUjKlzeQ";

            var subject = @"mailto:example@example.com";
            var publicKey = keys.PublicKey;
            var privateKey = keys.PrivateKey;

            var subscription = new PushSubscription(pushEndpoint, p256dh, auth);
            var vapidDetails = new VapidDetails(subject, publicKey, privateKey);

            var webPushClient = new WebPushClient();
            try
            {
                webPushClient.SendNotification(subscription, "payload", vapidDetails);
            }
            catch (WebPushException exception)
            {
                return exception.StatusCode.ToString();
            }

            return "OK";
        }

    }
}