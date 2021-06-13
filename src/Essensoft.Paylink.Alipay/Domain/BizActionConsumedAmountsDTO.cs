using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BizActionConsumedAmountsDTO Data Structure.
    /// </summary>
    public class BizActionConsumedAmountsDTO : AlipayObject
    {
        /// <summary>
        /// 业务预算申请占用金额集合
        /// </summary>
        [JsonPropertyName("biz_action_consumed_amount_list")]
        public List<BizActionConsumedAmountDTO> BizActionConsumedAmountList { get; set; }

        /// <summary>
        /// 业务预算申请占用金额集合
        /// </summary>
        [JsonPropertyName("biz_action_consumed_amounts")]
        public List<BizActionComsumedAmountDTO> BizActionConsumedAmounts { get; set; }

        /// <summary>
        /// 业务活动唯一id
        /// </summary>
        [JsonPropertyName("biz_uk_id")]
        public string BizUkId { get; set; }
    }
}
