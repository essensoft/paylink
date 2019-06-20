using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditCreditriskCustlabelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditCreditriskCustlabelQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝2088id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
