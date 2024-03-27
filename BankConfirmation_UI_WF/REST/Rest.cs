using Microsoft.Extensions.Configuration;

namespace BankConfirmation_UI_WF.REST
{
    internal class Rest
    {
        internal string baseAddress = GetApi();

        internal static string GetApi()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            string baseAddress = configuration["HostAPI"];
            return baseAddress;
        }
    }
}
