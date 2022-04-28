﻿// See https://aka.ms/new-console-template for more information
using System.Text.Json;

Console.WriteLine("Hello, World!");

using var stream = Console.OpenStandardOutput();
await JsonSerializer.SerializeAsync(stream, FetchItems());

Console.WriteLine("done");
Console.ReadLine();


static async IAsyncEnumerable<int> FetchItems()
{
    for (int i = 1; i <= 10; i++)
    {
        await Task.Delay(100);
        yield return i;
    }
}