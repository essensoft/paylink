using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeAdvanceConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAdvanceConsultModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
