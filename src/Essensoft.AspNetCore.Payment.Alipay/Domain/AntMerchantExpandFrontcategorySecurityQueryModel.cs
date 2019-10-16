using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandFrontcategorySecurityQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 前台类目归属主体ID  例：前台类目归属主体类型为店铺，则前台类目归属主体ID为店铺ID；
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 前台类目归属主体类型:  5（店铺）
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType { get; set; }
    }
}
