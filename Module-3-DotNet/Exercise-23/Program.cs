using System;
using System.Threading.Tasks;

namespace Module3.Exercise23
{
    class Program
    {
        static async Task<string> UploadAsync()
        {
            await Task.Delay(3000);
            return "Upload successful";
        }

        static async Task Main()
        {
            try
            {
                var result = await UploadAsync();
                Console.WriteLine(result);
            }
            catch(Exception ex) { Console.WriteLine($"Upload failed: {ex.Message}"); }
        }
    }
}
