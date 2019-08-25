using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbcloudSubuserinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 主账号ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
