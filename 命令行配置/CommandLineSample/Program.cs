using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;//引用了Microsoft.AspNetCore.All

namespace CommandLineSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = new Dictionary<string, string>
            {
                {"name", "Ben"},
                {"age", "18"}
            };

            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(setting)         //设置默认值
                .AddCommandLine(args);                  //参数通过 dotnet xxx.dll name="JJJ" age="99"格式传入

            var configuration = builder.Build();

            Console.WriteLine($"name:{configuration["name"]}");
            Console.WriteLine($"age:{configuration["age"]}");

            Console.ReadLine();

        }
    }
}
