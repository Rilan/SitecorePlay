using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fortis.Model;
using Lucene.Net.Support;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SitecorePlay.Web.Helpers;
using SitecorePlay.Web.Model;
using TweetSharp;

namespace SitecorePlay.Web.Controllers
{
    public class TwitterController : Controller
    {
        private readonly TwitterHelper _twitterHelper;

        public TwitterController(TwitterHelper twitterHelper)
        {
            _twitterHelper = twitterHelper;
        }


        public ActionResult TwitterFeed()
        {
            var currentTweets = _twitterHelper.GetTwitterService().ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions
            {
                ScreenName = _twitterHelper.ScreenName,
                Count = int.Parse(_twitterHelper.NoOfFeeds),
            });


            ViewData["tweets"] = currentTweets;

            return View();
        }

        public ActionResult TwitterFeedjson()
        {
            var currentTweets = _twitterHelper.GetTwitterService().ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions
            {
                ScreenName = _twitterHelper.ScreenName,
                Count = int.Parse(_twitterHelper.NoOfFeeds),
            });
            Session["tw"] = currentTweets;
            return View();
        }

        public JsonResult TwitterFeedjson1()
        {
            Tweets _tweet = null;
            List<Tweets> tweeterList = new List<Tweets>();
      

            var currentTweets = (IEnumerable<TwitterStatus>) Session["tw"];

            foreach (var item in currentTweets)
            {
                _tweet = new Tweets();

                _tweet.ScreenName = item.Author.ScreenName;
                _tweet.TextAsHtml = item.TextAsHtml;
                _tweet.Day = item.CreatedDate.Day.ToString();
                _tweet.Month = item.CreatedDate.Month.ToString();
                _tweet.Year = item.CreatedDate.Year.ToString();
                _tweet.ProfileImageUrl = item.Author.ProfileImageUrl;
                
                IList <TwitterMedia> mediaList = item.Entities.Media;

                foreach (var mediaItem in mediaList)
                {
                    _tweet.MediaUrl = mediaItem.MediaUrl;
                    //_tweet.MediaUrl = mediaItem.MediaUrlHttps;

                }



                tweeterList.Add(_tweet);
            }
            return Json(tweeterList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SendTweet(string sendtweets)
        {


            var result = _twitterHelper.GetTwitterService().SendTweet(new SendTweetOptions { Status = sendtweets });
            //if (result != null && result.Id > 0)
            //{
            //    Response.Redirect("https://twitter.com");              
            //}
            //else
            //{
            //    Response.Write("fails to update status");
            //}
            return View();
        }
    }
}