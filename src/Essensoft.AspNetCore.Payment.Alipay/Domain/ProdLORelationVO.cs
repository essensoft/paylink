using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdLORelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProdLORelationVO : AlipayObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("lo_code")]
        public string LoCode { get; set; }

        /// <summary>
        /// 区域类型
        /// </summary>
        [JsonProperty("lo_type")]
        public string LoType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonProperty("prod_version")]
        public string ProdVersion { get; set; }
    }
}
