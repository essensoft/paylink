using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// OperatorChannelInfo Data Structure.
    /// </summary>
    public class OperatorChannelInfo : AlipayObject
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 渠道描述
        /// </summary>
        [JsonProperty("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 渠道是否可用
        /// </summary>
        [JsonProperty("item_status")]
        public string ItemStatus { get; set; }
    }
}
