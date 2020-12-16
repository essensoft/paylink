using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthFieldDTO Data Structure.
    /// </summary>
    public class AuthFieldDTO : AlipayObject
    {
        /// <summary>
        /// 接口英文名称
        /// </summary>
        [JsonPropertyName("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 接口字段英文名称
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 接口归属的功能code
        /// </summary>
        [JsonPropertyName("package_code")]
        public string PackageCode { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// AUDIT 审核中，AGREE通过，REJECT驳回，INVALID无效（isv代申请场景)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户应用app_id
        /// </summary>
        [JsonPropertyName("user_app_id")]
        public string UserAppId { get; set; }
    }
}
