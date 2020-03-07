using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 营销海豚活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 咨询错误码：为空时表示活动咨询正常，不为空时表示活动咨询失败。
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 咨询错误码描述：为空时表示活动咨询正常，不为空时表示活动咨询失败
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 咨询有效的奖品列表，是一个ArrayList
        /// </summary>
        [JsonPropertyName("valid_prize_infos")]
        public List<KnPrizeInfo> ValidPrizeInfos { get; set; }
    }
}
