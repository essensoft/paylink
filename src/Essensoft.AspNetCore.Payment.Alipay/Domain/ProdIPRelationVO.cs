using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdIPRelationVO Data Structure.
    /// </summary>
    public class ProdIPRelationVO : AlipayObject
    {
        /// <summary>
        /// 参与者别名
        /// </summary>
        [JsonPropertyName("ip_alias_name")]
        public string IpAliasName { get; set; }

        /// <summary>
        /// 参与者所属平台
        /// </summary>
        [JsonPropertyName("ip_belong_platform")]
        public string IpBelongPlatform { get; set; }

        /// <summary>
        /// 参与者编码
        /// </summary>
        [JsonPropertyName("ip_code")]
        public string IpCode { get; set; }

        /// <summary>
        /// 参与者名称
        /// </summary>
        [JsonPropertyName("ip_name")]
        public string IpName { get; set; }

        /// <summary>
        /// 参与者子类型
        /// </summary>
        [JsonPropertyName("ip_sub_type")]
        public string IpSubType { get; set; }

        /// <summary>
        /// 参与者类型
        /// </summary>
        [JsonPropertyName("ip_type")]
        public string IpType { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonPropertyName("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 参与者平台Id
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
    }
}
