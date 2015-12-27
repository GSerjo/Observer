using System;
using System.Configuration;

namespace Amazon.SimpleQueue
{
    public sealed class QueueConfiguration
    {
        private QueueConfiguration()
        {
        }

        public string QueueUrl { get; set; }

        public static QueueConfiguration Create()
        {
            return new QueueConfiguration();
        }

        public QueueConfiguration Configure(Action<QueueConfiguration> action)
        {
            action(this);
            return this;
        }

        public IMessageQueue CreateQueu()
        {
            Validate();
            return new AmazonQueue();
        }

        private void Validate()
        {
            if (string.IsNullOrWhiteSpace(QueueUrl))
            {
                throw new ConfigurationErrorsException(nameof(QueueUrl));
            }
        }
    }
}