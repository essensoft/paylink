using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SignerBean Data Structure.
    /// </summary>
    public class SignerBean : AlipayObject
    {
        /// <summary>
        /// 个人邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 个人证件号
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 个人证件类型（证件号不为空时必填，详见个人证件类型说明 ）
        /// </summary>
        [JsonPropertyName("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 个人手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 个人姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 企业信息，signType=org时必填
        /// </summary>
        [JsonPropertyName("org")]
        public Org Org { get; set; }

        /// <summary>
        /// 个人唯一标识：可传入平台的个人用户id、支付宝userid、证件号、手机号、邮箱等。
        /// </summary>
        [JsonPropertyName("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
