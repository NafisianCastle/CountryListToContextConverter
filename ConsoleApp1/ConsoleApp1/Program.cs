﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\HP\Desktop\country.txt";
            var lines = new List<string>();
            if (File.Exists(file))
            {
                lines = File.ReadAllLines(file).ToList();
            }
            Console.WriteLine();
           
            var ans = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                var code = lines[i].Split(' ')[0].Trim();
                var name = string.Join(" ", lines[i].Split(' ').Skip(1)).Trim();
                var test = "context.countries.Add(new Country{ CountryCode = \"" + code + "\",CountryName = \"" + name + "\", CreatedAt = System.DateTime.Now,CreatedBy = \"System\"});\n\rcontext.SaveChanges();";
               
                ans.Add(test);
            }
            File.WriteAllLines(@"C:\Users\HP\Desktop\done.txt", ans);
        }
    }

}
