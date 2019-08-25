using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperatorSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperatorSyncModel : AlipayObject
    {
        /// <summary>
        /// 主账号的userId
        /// </summary>
        [JsonProperty("master_user_id")]
        public string MasterUserId { get; set; }

        /// <summary>
        /// 产品code，FINCLOUD=金融云，CSC=云客服
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }
    }
}
