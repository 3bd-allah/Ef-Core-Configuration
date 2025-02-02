﻿using ConfigurationByConvention.Data;

namespace ConfigurationByConvention
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new AppDbContext())
            {

                Console.WriteLine("--------- Users ---------------");
                Console.WriteLine();
                foreach(var user in context.Users)
                    Console.WriteLine(user.Username);


                Console.WriteLine("--------- Tweets ---------------");
                Console.WriteLine();
                foreach(var tweet in context.Tweets)
                    Console.WriteLine(tweet.TweetText);

                Console.WriteLine("--------- Comments ---------------");
                Console.WriteLine();
                foreach(var comment in context.Comments)
                    Console.WriteLine(comment.CommentText);

            }

            Console.ReadKey();


        }
    }
}
