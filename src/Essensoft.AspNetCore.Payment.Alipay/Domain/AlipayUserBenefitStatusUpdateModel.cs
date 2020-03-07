using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserBenefitStatusUpdateModel Data Structure.
    /// </summary>
    public class AlipayUserBenefitStatusUpdateModel : AlipayObject
    {
        /// <summary>
        /// 权益的ID
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// YES表示当前操作的是会员3.0权益，NO表示当前操作的是改版之前的权益
        /// </summary>
        [JsonPropertyName("benefit_new_flag")]
        public string BenefitNewFlag { get; set; }

        /// <summary>
        /// 1:上线， 0:下线,  2:失效；  上线状态所有人可见，不可编辑；  下线状态白名单可见，可以编辑；  失效状态所有人不可见，不可编辑。
        /// </summary>
        [JsonPropertyName("benefit_status")]
        public string BenefitStatus { get; set; }
    }
}
