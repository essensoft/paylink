using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAddChannelRequest Data Structure.
    /// </summary>
    public class KbAdvertAddChannelRequest : AlipayObject
    {
        /// <summary>
        /// 描述信息(页面上不展现)
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类型可以通过koubei.advert.data.conf.query查询  OFFLINE：线下推广
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
