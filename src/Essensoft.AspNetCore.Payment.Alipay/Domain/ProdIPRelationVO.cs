using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdIPRelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProdIPRelationVO : AlipayObject
    {
        /// <summary>
        /// 参与者别名
        /// </summary>
        [JsonProperty("ip_alias_name")]
        public string IpAliasName { get; set; }

        /// <summary>
        /// 参与者所属平台
        /// </summary>
        [JsonProperty("ip_belong_platform")]
        public string IpBelongPlatform { get; set; }

        /// <summary>
        /// 参与者编码
        /// </summary>
        [JsonProperty("ip_code")]
        public string IpCode { get; set; }

        /// <summary>
        /// 参与者名称
        /// </summary>
        [JsonProperty("ip_name")]
        public string IpName { get; set; }

        /// <summary>
        /// 参与者子类型
        /// </summary>
        [JsonProperty("ip_sub_type")]
        public string IpSubType { get; set; }

        /// <summary>
        /// 参与者类型
        /// </summary>
        [JsonProperty("ip_type")]
        public string IpType { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonProperty("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 参与者平台Id
        /// </summary>
        [JsonProperty("role_id")]
        public string RoleId { get; set; }
    }
}
