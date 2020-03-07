using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdAduserqualificationCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdAduserqualificationCreateModel : AlipayObject
    {
        /// <summary>
        /// 用户id + 广告用户提交信息以及材料来创建对应的资质信息
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告用户填写的用户资质信息 +  根据广告用户填写的资质信息完成相应的资质创建
        /// </summary>
        [JsonPropertyName("ad_user_qualification")]
        public AdUserQualification AdUserQualification { get; set; }
    }
}
