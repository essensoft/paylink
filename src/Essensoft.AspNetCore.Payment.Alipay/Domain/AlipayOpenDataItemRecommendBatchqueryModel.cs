using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenDataItemRecommendBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenDataItemRecommendBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 国家地区行政编码
        /// </summary>
        [JsonProperty("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 展位ID,支持批量咨询，多个展位用逗号分隔
        /// </summary>
        [JsonProperty("position_ids")]
        public string PositionIds { get; set; }

        /// <summary>
        /// 用户的支付宝UID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
