using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampUpdateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 操作结果状态，true表示修改成功立即生效，false表示修改失败
        /// </summary>
        [JsonPropertyName("camp_result")]
        public bool CampResult { get; set; }
    }
}
