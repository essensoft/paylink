using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandFrontcategorySecurityCreateModel : AlipayObject
    {
        /// <summary>
        /// 前台类目描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 素材列表（最多3个）
        /// </summary>
        [JsonProperty("material_list")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

        /// <summary>
        /// 前台类目名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

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
