using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMemberSceneQueryModel Data Structure.
    /// </summary>
    public class AlipayUserMemberSceneQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 场景名称。  支持的场景：  COLLEGE_LIFE（大学生活）
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
