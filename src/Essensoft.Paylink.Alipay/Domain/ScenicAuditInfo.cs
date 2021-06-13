using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ScenicAuditInfo Data Structure.
    /// </summary>
    public class ScenicAuditInfo : AlipayObject
    {
        /// <summary>
        /// 审核信息
        /// </summary>
        [JsonPropertyName("audit_msg")]
        public string AuditMsg { get; set; }

        /// <summary>
        /// 审核结果
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 内外id映射关系创建时间
        /// </summary>
        [JsonPropertyName("import_gmt_create")]
        public string ImportGmtCreate { get; set; }

        /// <summary>
        /// 服务商景区ID
        /// </summary>
        [JsonPropertyName("outer_id_isv")]
        public string OuterIdIsv { get; set; }

        /// <summary>
        /// 支付宝域内维护的景区外部id
        /// </summary>
        [JsonPropertyName("outer_id_zfb")]
        public string OuterIdZfb { get; set; }

        /// <summary>
        /// 服务商负责的景区小程序APPID
        /// </summary>
        [JsonPropertyName("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 支付宝域景区ID
        /// </summary>
        [JsonPropertyName("scenic_id")]
        public string ScenicId { get; set; }
    }
}
