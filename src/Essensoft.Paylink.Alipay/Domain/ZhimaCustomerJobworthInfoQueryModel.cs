using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthInfoQueryModel Data Structure.
    /// </summary>
    public class ZhimaCustomerJobworthInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 若用户没有开通工作证或者芝麻，成功开通后回跳的链接
        /// </summary>
        [JsonPropertyName("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
