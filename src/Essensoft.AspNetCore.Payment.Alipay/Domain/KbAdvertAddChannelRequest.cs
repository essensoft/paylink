using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAddChannelRequest Data Structure.
    /// </summary>
    public class KbAdvertAddChannelRequest : AlipayObject
    {
        /// <summary>
        /// 描述信息(页面上不展现)
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类型可以通过koubei.advert.data.conf.query查询  OFFLINE：线下推广
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
