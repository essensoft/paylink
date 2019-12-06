using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitShopQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignRecruitShopQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 参与的商户Id
        /// </summary>
        [JsonPropertyName("invitee")]
        public string Invitee { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
