using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdCtidVerifyModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdCtidVerifyModel : AlipayObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 认证模式
        /// </summary>
        [JsonPropertyName("identify_model")]
        public string IdentifyModel { get; set; }

        /// <summary>
        /// 图片的base64编码
        /// </summary>
        [JsonPropertyName("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 个人用户姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
