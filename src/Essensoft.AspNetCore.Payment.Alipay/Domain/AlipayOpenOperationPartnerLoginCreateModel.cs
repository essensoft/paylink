using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationPartnerLoginCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenOperationPartnerLoginCreateModel : AlipayObject
    {
        /// <summary>
        /// 三方合作服务商的员工支付宝UID，要求唯一。需要三方员工通过授权操作提供。
        /// </summary>
        [JsonPropertyName("staff_user_id")]
        public string StaffUserId { get; set; }
    }
}
