using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduCampusJobstudentApplyModel Data Structure.
    /// </summary>
    public class AlipayEcoEduCampusJobstudentApplyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝客户端用户Id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 备用字段，JSON格式.（可使用单引号或者双引号）
        /// </summary>
        [JsonPropertyName("content_var")]
        public string ContentVar { get; set; }
    }
}
