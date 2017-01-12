using System;
using System.Linq;

namespace WhatTimeZones
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZoneInfo.GetSystemTimeZones().ToList()
                .ForEach(x => 
                Console.WriteLine($"-----------------------------------------{Environment.NewLine}" +
                                  $"ID: {x.Id} {Environment.NewLine}" +
                                  $"DisplayName: {x.DisplayName}{Environment.NewLine}" +
                                  $"StandardName: {x.StandardName}"));

            Console.ReadLine();
        }
    }
}
