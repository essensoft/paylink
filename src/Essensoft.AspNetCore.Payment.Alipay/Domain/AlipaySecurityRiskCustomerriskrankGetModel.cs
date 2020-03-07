using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskCustomerriskrankGetModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskCustomerriskrankGetModel : AlipayObject
    {
        /// <summary>
        /// 证件号码，除了场景id必填，其他几个参数不能同时为空
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 证件类型，除了场景id必填，其他几个参数不能同时为空
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 手机号，除了场景id必填，其他几个参数不能同时为空
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 支付宝账户id ，除了场景id必填，其他几个参数不能同时为空
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
