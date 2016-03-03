using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace WebJob1
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    public class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            JobHostConfiguration config = new JobHostConfiguration();
            config.UseTimers();
            JobHost host = new JobHost(config);
            host.RunAndBlock();
        }


        // Run daily at midnight
        public static void RunAtMidnight([TimerTrigger("0 0 0 * * *", RunOnStartup = true)] TimerInfo info)
        {
            Console.WriteLine("Timer job fired!");
        }
    }
}
