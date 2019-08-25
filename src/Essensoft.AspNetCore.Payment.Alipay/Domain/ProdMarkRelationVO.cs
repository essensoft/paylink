using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdMarkRelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProdMarkRelationVO : AlipayObject
    {
        /// <summary>
        /// 产品外标编码
        /// </summary>
        [JsonProperty("mark_code")]
        public string MarkCode { get; set; }

        /// <summary>
        /// 产品外标类型
        /// </summary>
        [JsonProperty("mark_type")]
        public string MarkType { get; set; }

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
