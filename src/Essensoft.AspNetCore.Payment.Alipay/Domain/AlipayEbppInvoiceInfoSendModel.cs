using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInfoSendModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceInfoSendModel : AlipayObject
    {
        /// <summary>
        /// 发票信息列表
        /// </summary>
        [JsonPropertyName("invoice_info_list")]
        public List<InvoiceSendOpenModel> InvoiceInfoList { get; set; }

        /// <summary>
        /// 开票商户品牌简称，与商户入驻时的品牌简称保持一致。
        /// </summary>
        [JsonPropertyName("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 开票商户门店简称，与商户入驻时的门店简称保持一致。
        /// </summary>
        [JsonPropertyName("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
