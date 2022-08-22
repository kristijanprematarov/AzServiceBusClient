using Azure.Messaging.ServiceBus;

string connectionString = "Endpoint=sb://kpr-servicebus.servicebus.windows.net/;SharedAccessKeyName=ReadWrite;SharedAccessKey=wKeIrWvOCJ8vlpunfuISPcg5djW8JxUC/A2PC9y7ULY=;";

string queueName = "orderqueue";

ServiceBusClient client = new ServiceBusClient(connectionString);

ServiceBusSender sender = client.CreateSender(queueName);

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

await sender.SendMessageAsync(new ServiceBusMessage(@$"Message: {name}"));
