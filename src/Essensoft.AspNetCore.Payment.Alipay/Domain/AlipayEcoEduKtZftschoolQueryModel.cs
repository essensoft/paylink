using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtZftschoolQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtZftschoolQueryModel : AlipayObject
    {
        /// <summary>
        /// 进件单号id，进件接口返回
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// ISV的支付宝唯一标识PID
        /// </summary>
        [JsonProperty("partner_pid")]
        public string PartnerPid { get; set; }
    }
}
