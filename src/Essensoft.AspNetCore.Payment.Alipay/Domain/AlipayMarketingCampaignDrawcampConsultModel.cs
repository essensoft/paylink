using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampConsultModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampConsultModel : AlipayObject
    {
        /// <summary>
        /// 营销海豚活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 扩展字段Map，格式为{"key","value"}，其中key需要与支付宝营销平台约定
        /// </summary>
        [JsonPropertyName("ext_params")]
        public ConsultExtParams ExtParams { get; set; }

        /// <summary>
        /// 指定过滤奖品id列表，最多支持10个，多个奖品用英文逗号分割，为空时咨询活动下所有的奖品
        /// </summary>
        [JsonPropertyName("prize_id_list")]
        public string PrizeIdList { get; set; }

        /// <summary>
        /// 系统来源，接入请和支付宝营销平台开发or产品同学申请
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
