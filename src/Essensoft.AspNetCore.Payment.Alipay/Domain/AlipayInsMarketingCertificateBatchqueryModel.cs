using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingCertificateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 32
        /// </summary>
        [JsonProperty("certificate_no")]
        [XmlElement("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 凭证类型
        /// </summary>
        [JsonProperty("certificate_type")]
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("current_page_no")]
        [XmlElement("current_page_no")]
        public long CurrentPageNo { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonProperty("effect_time")]
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [JsonProperty("inst_id")]
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 是否失效
        /// </summary>
        [JsonProperty("is_enabled")]
        [XmlElement("is_enabled")]
        public string IsEnabled { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("order_id")]
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [JsonProperty("order_source")]
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拥有人uid
        /// </summary>
        [JsonProperty("owner_uid")]
        [XmlElement("owner_uid")]
        public string OwnerUid { get; set; }

        /// <summary>
        /// 每页记录数量
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 凭证状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
