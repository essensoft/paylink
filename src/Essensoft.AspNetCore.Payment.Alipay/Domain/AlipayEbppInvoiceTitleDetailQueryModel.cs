using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 商户的品牌名称简称,该字段需要接入前向发票管家申请，  m_short_name+sub_m_short_name具有唯一约束  如：肯德基：KFC
        /// </summary>
        [JsonProperty("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 支付宝为商户分配的商户门店简称，该字段需要接入前在发票管家申请  如：肯德基-杭州西湖区文一西路店：KFC-HZ-XH001
        /// </summary>
        [JsonProperty("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
