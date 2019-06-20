using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdRelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProdRelationVO : AlipayObject
    {
        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("num")]
        public long Num { get; set; }

        /// <summary>
        /// 数量类型
        /// </summary>
        [JsonProperty("num_type")]
        public string NumType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 关联的产品编码
        /// </summary>
        [JsonProperty("prod_rel_code")]
        public string ProdRelCode { get; set; }

        /// <summary>
        /// 关联的产品名称
        /// </summary>
        [JsonProperty("prod_rel_name")]
        public string ProdRelName { get; set; }

        /// <summary>
        /// 产品关联类型
        /// </summary>
        [JsonProperty("prod_rel_type")]
        public string ProdRelType { get; set; }

        /// <summary>
        /// 关联的产品版本
        /// </summary>
        [JsonProperty("prod_rel_version")]
        public string ProdRelVersion { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonProperty("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 产品关联子类型
        /// </summary>
        [JsonProperty("sub_prod_rel_type")]
        public string SubProdRelType { get; set; }
    }
}
