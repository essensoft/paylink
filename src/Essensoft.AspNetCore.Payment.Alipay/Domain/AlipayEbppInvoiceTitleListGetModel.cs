using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleListGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleListGetModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
