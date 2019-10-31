using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品状态：EFFECT（有效）、INVALID（无效）
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；归属主体为小程序，则归属主体ID为小程序ID
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型:  5（店铺）  8（小程序）
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType { get; set; }
    }
}
