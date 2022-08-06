﻿using System.Text;

int jumpCount = 10;
string[] animals = {"cat", "dog", "sheep"};

StringBuilder sb = new StringBuilder("Initial string.", 200);

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

sb.Append("The quick brown fox ");
sb.Append("jumped over the lazy dog");

sb.AppendLine();

sb.AppendFormat("He did this {0} times", jumpCount);
sb.AppendLine();

sb.Append("He also jumped over ");
sb.AppendJoin(",", animals);

sb.Replace("fox", "cat");

sb.Insert(0, "This is the ");

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
Console.WriteLine(sb.ToString());