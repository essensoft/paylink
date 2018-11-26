using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceKeyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceKeyInfo : AlipayObject
    {
        /// <summary>
        /// 开票商户名称：商户品牌简称|商户门店简称
        /// </summary>
        [JsonProperty("invoice_merchant_name")]
        [XmlElement("invoice_merchant_name")]
        public string InvoiceMerchantName { get; set; }

        /// <summary>
        /// 该交易是否支持开票
        /// </summary>
        [JsonProperty("is_support_invoice")]
        [XmlElement("is_support_invoice")]
        public bool IsSupportInvoice { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [JsonProperty("tax_num")]
        [XmlElement("tax_num")]
        public string TaxNum { get; set; }
    }
}
