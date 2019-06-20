using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityParticipatedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityParticipatedQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户ID，唯一键标识用户身份。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
