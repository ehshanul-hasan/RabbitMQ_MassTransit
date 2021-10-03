using Infrastructure;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBIService.Consumers
{
    public class BIDataConsumer : IConsumer<BIDataModel>
    {
        public async Task Consume(ConsumeContext<BIDataModel> context)
        {
            var data = context.Message;
            Console.WriteLine("Hi ! I am from pbi");
            //Validate the Ticket Data
            //Store to Database
            //Notify the user via Email / SMS
        }
    }
}
