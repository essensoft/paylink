using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelBenefitChangeNotifyModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelBenefitChangeNotifyModel : AlipayObject
    {
        /// <summary>
        /// 收单站在gn的id
        /// </summary>
        [JsonPropertyName("acquirer_id")]
        public string AcquirerId { get; set; }

        /// <summary>
        /// 权益详情列表
        /// </summary>
        [JsonPropertyName("benefit_detail_info_list")]
        public List<BenefitDetailInfo> BenefitDetailInfoList { get; set; }

        /// <summary>
        /// 发卡站在gn的id
        /// </summary>
        [JsonPropertyName("psp_id")]
        public string PspId { get; set; }
    }
}
