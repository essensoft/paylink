using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Signer Data Structure.
    /// </summary>
    public class Signer : AlipayObject
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 证件类型,详见个人证件类型说明（http://open.esign.cn/docs/xy/%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3/%E9%99%84%E5%BD%95/%E4%B8%AA%E4%BA%BA%E8%AF%81%E4%BB%B6%E7%B1%BB%E5%9E%8B.html），默认CRED_PSN_CH_IDCARD (证件号不为空，则必填)
        /// </summary>
        [JsonPropertyName("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
