using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ConsumerProfile Data Structure.
    /// </summary>
    public class ConsumerProfile : AlipayObject
    {
        /// <summary>
        /// 消费者画像，包含各年龄段消费者人群占比， 性别占比、复购次数占比等
        /// </summary>
        [JsonPropertyName("consumer_profile")]
        public string ConsumerProfile_ { get; set; }
    }
}
