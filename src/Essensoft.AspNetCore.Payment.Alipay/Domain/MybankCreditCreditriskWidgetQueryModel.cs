using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditCreditriskWidgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditCreditriskWidgetQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝userid
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
