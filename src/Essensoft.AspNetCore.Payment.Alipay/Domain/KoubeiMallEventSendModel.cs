using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallEventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallEventSendModel : AlipayObject
    {
        /// <summary>
        /// 业务号
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 事件业务数据
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 事件码
        /// </summary>
        [JsonProperty("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }
    }
}
