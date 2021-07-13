using Azure;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using System;
using System.Threading.Tasks;

namespace EventPublisher
{
    public class Program
    {
        private const string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=asyncstorjsr;AccountKey=nHCwCRakAXWRuWrAi6Bz008dt809y2oEz0Dg5/tjRK2kyEV3gd38JRdDtwbvuLv+Rmjehdm1pJmDQE36WqfrKQ==;EndpointSuffix=core.windows.net";
        private const string queueName = "messagequeue";

        public static async Task Main(string[] args)
{
            QueueClient client = new QueueClient(storageConnectionString, queueName);
            await client.CreateAsync();

            Console.WriteLine($"---Account Metadata---");
            Console.WriteLine($"Account Uri:\t{client.Uri}");

            Console.WriteLine($"---Existing Messages---");
            int batchSize = 10;
            TimeSpan visibilityTimeout = TimeSpan.FromSeconds(2.5d);

            Response<QueueMessage[]> messages = await client.ReceiveMessagesAsync(batchSize, visibilityTimeout);

            foreach(QueueMessage message in messages?.Value)
            {
                Console.WriteLine($"[{message.MessageId}]\t{message.MessageText}");
                await client.DeleteMessageAsync(message.MessageId, message.PopReceipt);
            }

            Console.WriteLine($"---New Messages---");
            string greeting = "Hi, Developer!";
            await client.SendMessageAsync(greeting);
    
            Console.WriteLine($"Sent Message:\t{greeting}");


        }
    }
}
