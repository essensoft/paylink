using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExratePricingNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExratePricingNotifyModel : AlipayObject
    {
        /// <summary>
        /// 标识该汇率提供给哪个客户使用
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 源汇率机构
        /// </summary>
        [JsonProperty("inst")]
        public string Inst { get; set; }

        /// <summary>
        /// 源汇率数据
        /// </summary>
        [JsonProperty("pricing_list")]
        public List<PricingVO> PricingList { get; set; }

        /// <summary>
        /// 该汇率的使用场景
        /// </summary>
        [JsonProperty("segment_id")]
        public string SegmentId { get; set; }

        /// <summary>
        /// 所在时区，所有的时间都是该时区的时间  支持 GMT+8 UTC+0 Europe/London 的格式
        /// </summary>
        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }
    }
}
