using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayAccount Data Structure.
    /// </summary>
    public class AlipayAccount : AlipayObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 可用余额
        /// </summary>
        [JsonProperty("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 不可用余额
        /// </summary>
        [JsonProperty("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 余额总额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
