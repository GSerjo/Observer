using Amazon.SQS;
using Xunit;

namespace UnitTests
{
    public sealed class ForTest
    {
        [Fact]
        public void Test()
        {
            var config = new AmazonSQSConfig
            {
                 
            };
            var client = new AmazonSQSClient(config);
        }
    }
}