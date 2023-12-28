using Inveon.Services.Inform.CommunicationMethods;
using Inveon.Services.Inform.CommunicationMethods.Interfaces;
using Inveon.Models.DTOs;
using Inveon.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Inveon.Services.Inform
{
    public class CheckoutInformHandler : BackgroundService
    {
        private readonly string _hostname;
        private readonly string _password;
        private readonly string _username;
        private readonly string _queueName;
        private IConnection? _connection;
        private ICommunicationMethod _emailSender;

        public CheckoutInformHandler()
        {
            _hostname = "localhost";
            _password = "guest";
            _username = "guest";
            _queueName = "informQueue";
            _emailSender = new EmailSender();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (ConnectionExists())
            {
                var channel = _connection.CreateModel();
                
                channel.QueueDeclare(queue: _queueName, false, false, false, arguments: null);

                var consumer = new AsyncEventingBasicConsumer(channel);

                consumer.Received += async (model, ea) =>
                {
                    ulong deliveryTag = ea.DeliveryTag;
                    var body = ea.Body.ToArray();
                    string message = Encoding.UTF8.GetString(body);
                    CheckoutHeaderWithProducts messageObject = JsonConvert.DeserializeObject<CheckoutHeaderWithProducts>(message);

                    try
                    {
                        HandleMessage(messageObject);
                        channel.BasicAck(deliveryTag, false);
                    }
                    catch (Exception e)
                    {
                        Console.Write("Email could not be sent: ");
                        Console.WriteLine(e.Message);
                        channel.BasicNack(deliveryTag, false, true);
                    }
                    await Task.Yield();
                };

                channel.BasicConsume(queue: _queueName,
                                        autoAck: false,
                                        consumer: consumer);
            }
            

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000, stoppingToken);
            }  
        }

        public void HandleMessage(CheckoutHeaderWithProducts checkoutHeader) 
        {
            _emailSender.SendMessage(checkoutHeader);
        }

        private bool ConnectionExists()
        {
            if (_connection != null)
            {
                return true;
            }
            else
            {
                CreateConnection();
                return _connection != null;
            }
        }
        private void CreateConnection()
        {
            var factory = new ConnectionFactory
            {
                HostName = _hostname,
                UserName = _username,
                Password = _password,
                DispatchConsumersAsync = true
            };
            _connection = factory.CreateConnection();
        }
    }
}