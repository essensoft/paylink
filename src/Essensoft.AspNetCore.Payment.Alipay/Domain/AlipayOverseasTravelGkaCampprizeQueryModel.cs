using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelGkaCampprizeQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelGkaCampprizeQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id，获取方式：联系支付宝运营同学获取（适用于支付宝平台活动，由合作伙伴调用触发）
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 用户参与活动的手机号
        /// </summary>
        [JsonPropertyName("login_mobile")]
        public string LoginMobile { get; set; }

        /// <summary>
        /// 支付宝用户uid：支付宝用户唯一标识。user_id、bind_mobile两个参数至少有一个非空。使用优先级为 user_id > bind_mobile
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
