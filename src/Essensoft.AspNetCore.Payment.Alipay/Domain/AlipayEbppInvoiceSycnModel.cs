using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceSycnModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceSycnModel : AlipayObject
    {
        /// <summary>
        /// 同步发票信息模型
        /// </summary>
        [JsonPropertyName("invoice_info")]
        public List<InvoiceModelContent> InvoiceInfo { get; set; }

        /// <summary>
        /// 商户的品牌名称简称,该字段需要接入前向发票管家申请，  m_short_name+sub_m_short_name具有唯一约束  如：肯德基：KFC
        /// </summary>
        [JsonPropertyName("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 支付宝为商户分配的商户门店简称，该字段需要接入前在发票管家申请  如：肯德基-杭州西湖区文一西路店：KFC-HZ-XH001
        /// </summary>
        [JsonPropertyName("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
