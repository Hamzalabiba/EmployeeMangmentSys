using System.Text;
using RabbitMQ.Stream.Client;
using RabbitMQ.Stream.Client.Reliable;
namespace SignalRChat.RabbitMQTest
{
    public class Send
    {
        public async void SendMthod() 
        { 
            var streamSystem = await StreamSystem.Create(new StreamSystemConfig());

            await streamSystem.CreateStream(new StreamSpec("Hello-Stream") {
            
            MaxLengthBytes = 5_000_000_000,
            });
            var producer = await Producer.Create(new ProducerConfig(streamSystem,"Hello-Stream"));
            await producer.Send(new Message(Encoding.UTF8.GetBytes($"Hello,World")));
        }
    }
}
