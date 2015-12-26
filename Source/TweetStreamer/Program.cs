﻿using System;
using TwitterInfrastructure;
using TwitterInfrastructure.Contracts;
using TwitterInfrastructure.Contracts.Models;

namespace TweetStreamer
{
    internal class Program
    {
        private static void Main()
        {
            var accessToken = "874229294-vTpHJDcl8K0I7Ae6H29Ezvpw5ZVsX3uT2wbtDNkD";
            var accessTokenSecret = "3XNHrHBanj3x2fOTCm53t7L6hd7NSDlLqWIgc24um3x83";
            var customerKey = "kO6JlIwLa4czaQSqvHXLFfOhb";
            var customerSecret = "rSbhwvMR0vq1UCpkztfl3PvazveNHCKg6879J8yd0kLu7Q0xSF";

            var config = new TwetterConfig
            {
                ConsumerKey = customerKey,
                ConsumerSecret = customerSecret,
                AccessToken = accessToken,
                AccessSecret = accessTokenSecret,
                TrackKeywords = { "russia" }
            };
            var client = new TwitterClient(config, new TwitterObserver());

            client.Start2();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

    internal sealed class TwitterObserver : ITwitterObserver
    {
        public void Notify(Tweet tweet)
        {
            Console.WriteLine(tweet);
            Console.WriteLine(Environment.NewLine);
        }
    }
}