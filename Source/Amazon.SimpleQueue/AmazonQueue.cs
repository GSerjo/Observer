using Amazon.SQS;

namespace Amazon.SimpleQueue
{
    public sealed class AmazonQueue : IMessageQueue
    {
        private readonly AmazonSQSClient _client = new AmazonSQSClient();

        public void Send(object value)
        {
        }
    }
}