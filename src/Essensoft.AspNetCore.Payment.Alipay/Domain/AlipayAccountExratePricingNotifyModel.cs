using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExratePricingNotifyModel Data Structure.
    /// </summary>
    public class AlipayAccountExratePricingNotifyModel : AlipayObject
    {
        /// <summary>
        /// 标识该汇率提供给哪个客户使用
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 源汇率机构
        /// </summary>
        [JsonPropertyName("inst")]
        public string Inst { get; set; }

        /// <summary>
        /// 源汇率数据
        /// </summary>
        [JsonPropertyName("pricing_list")]
        public List<PricingVO> PricingList { get; set; }

        /// <summary>
        /// 该汇率的使用场景
        /// </summary>
        [JsonPropertyName("segment_id")]
        public string SegmentId { get; set; }

        /// <summary>
        /// 所在时区，所有的时间都是该时区的时间  支持 GMT+8 UTC+0 Europe/London 的格式
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }
    }
}
