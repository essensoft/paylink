using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 代理商访问灯火平台的token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 分页参数之页数，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小，最大1000
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家标志
        /// </summary>
        [JsonPropertyName("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 推广页类型：COLLECT_INFO -  普通留资;TRADE - 交易留资
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
