using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询ID：用于标示一张发票，通过发票综合查询可以查询到该ID。
        /// </summary>
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
