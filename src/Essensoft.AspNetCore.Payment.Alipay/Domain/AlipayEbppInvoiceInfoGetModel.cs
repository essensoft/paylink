using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInfoGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInfoGetModel : AlipayObject
    {
        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 用户id，当用户发起发票查询时，可以先通过用户授权获取当前访问用户的userId
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
