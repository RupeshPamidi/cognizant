using System;
using System.IO;
using System.Text.Json;

namespace Module3.Exercise24
{
    class User { public string Name { get; set; } = ""; public int Age { get; set; } public string Email { get; set; } = ""; }
    class Program
    {
        static void Main()
        {
            var user = new User{ Name="Sam", Age=28, Email="sam@example.com" };
            var json = JsonSerializer.Serialize(user);
            File.WriteAllText("user.json", json);
            var loaded = JsonSerializer.Deserialize<User>(File.ReadAllText("user.json"));
            Console.WriteLine($"Loaded: {loaded?.Name} {loaded?.Age} {loaded?.Email}");
        }
    }
}
