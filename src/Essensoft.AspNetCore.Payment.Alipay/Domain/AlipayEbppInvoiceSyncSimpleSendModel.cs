using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceSyncSimpleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceSyncSimpleSendModel : AlipayObject
    {
        /// <summary>
        /// 回传的发票信息
        /// </summary>
        [JsonProperty("invoice_info")]
        public InvoicePDFSynModel InvoiceInfo { get; set; }

        /// <summary>
        /// 开票商户品牌简称，与商户入驻时的品牌简称保持一致。
        /// </summary>
        [JsonProperty("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 开票商户门店简称，与商户入驻时的门店简称保持一致。
        /// </summary>
        [JsonProperty("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
