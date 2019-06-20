using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorFreezeModel : AlipayObject
    {
        /// <summary>
        /// 操作码
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonProperty("operator_id")]
        public string OperatorId { get; set; }
    }
}
