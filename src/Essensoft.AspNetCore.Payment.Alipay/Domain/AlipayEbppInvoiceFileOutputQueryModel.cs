using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFileOutputQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceFileOutputQueryModel : AlipayObject
    {
        /// <summary>
        /// 发票代码  字段长度（10-12位）
        /// </summary>
        [JsonProperty("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码  字段长度（8-10位）
        /// </summary>
        [JsonProperty("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票pdf文件下载应用场景  固定值－INVOICE_EXPENSE
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
