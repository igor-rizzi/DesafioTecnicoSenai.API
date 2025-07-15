namespace EmailWorker.Services
{
    public interface IRabbitMqService
    {
        Task ConsumirFila(Func<string, Task> onMessageReceived);
    }
}
