using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SmartAutomatAssociate Data Structure.
    /// </summary>
    public class SmartAutomatAssociate : AlipayObject
    {
        /// <summary>
        /// 合作伙伴类型  DISTRIBUTORS:渠道商
        /// </summary>
        [JsonPropertyName("associate_type")]
        public string AssociateType { get; set; }

        /// <summary>
        /// 合作伙伴的支付宝账号ID
        /// </summary>
        [JsonPropertyName("associate_user_id")]
        public string AssociateUserId { get; set; }
    }
}
