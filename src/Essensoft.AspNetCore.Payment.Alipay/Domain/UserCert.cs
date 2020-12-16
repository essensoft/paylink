using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserCert Data Structure.
    /// </summary>
    public class UserCert : AlipayObject
    {
        /// <summary>
        /// 申请证书的时间，不是种树时间
        /// </summary>
        [JsonPropertyName("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 用户环保证书id
        /// </summary>
        [JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 扩展信息，格式为JSON字符串，具体k-v需要跟接口提供方确认后使用
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 树已经种下时所在的林区id
        /// </summary>
        [JsonPropertyName("forest_id")]
        public string ForestId { get; set; }

        /// <summary>
        /// 公益机构名称
        /// </summary>
        [JsonPropertyName("ngo_name")]
        public string NgoName { get; set; }

        /// <summary>
        /// 树种是否种下
        /// </summary>
        [JsonPropertyName("planted")]
        public bool Planted { get; set; }

        /// <summary>
        /// 树种或保护地所在区域
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// 树种或者保护地名称
        /// </summary>
        [JsonPropertyName("tree_name")]
        public string TreeName { get; set; }

        /// <summary>
        /// 证书类型：树种-"TREE"/保护地-"RESERVE"
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
