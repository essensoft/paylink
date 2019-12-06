using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayInsMarketingCertificateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 32
        /// </summary>
        [JsonPropertyName("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 凭证类型
        /// </summary>
        [JsonPropertyName("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_page_no")]
        public long CurrentPageNo { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonPropertyName("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 是否失效
        /// </summary>
        [JsonPropertyName("is_enabled")]
        public string IsEnabled { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [JsonPropertyName("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拥有人uid
        /// </summary>
        [JsonPropertyName("owner_uid")]
        public string OwnerUid { get; set; }

        /// <summary>
        /// 每页记录数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 凭证状态
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
