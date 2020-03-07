using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardInstanceDO Data Structure.
    /// </summary>
    public class CardInstanceDO : AlipayObject
    {
        /// <summary>
        /// 小目标卡片Id
        /// </summary>
        [JsonPropertyName("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 用户获得卡片的当前星级
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// 卡片最大星级
        /// </summary>
        [JsonPropertyName("max_level")]
        public long MaxLevel { get; set; }

        /// <summary>
        /// 小目标卡片名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
