using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitPlanlistQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingRecruitPlanlistQueryModel : AlipayObject
    {
        /// <summary>
        /// 第几页，默认1（需要在1和999之间）
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20，需要在1和100之间
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
