using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;

namespace BankConfirmation_UI_WF.REST
{
    internal class Rest
    {
        //private static string GetPath()
        //{
        //    string path = "appsettings.json";

        //    using (FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read))
        //    {
        //        byte[] bt = new byte[1024];
        //        UTF8Encoding end = new(true);

        //        while (fileStream.Read(bt, 0, bt.Length) > 0)
        //        {
        //            return end.GetString(bt);
        //        }
        //    }
        //    return null;
        //}
        //private static dynamic json = JsonConvert.DeserializeObject(GetPath());
        //internal readonly string baseAddress = (string)json["HostApi"];

        internal string baseAddress = M();

        internal static string M()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            string baseAddress = configuration["HostAPI"];
            return baseAddress;
        }
    }
}
