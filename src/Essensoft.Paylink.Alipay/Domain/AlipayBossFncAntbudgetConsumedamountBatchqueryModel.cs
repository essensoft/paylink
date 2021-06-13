using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetConsumedamountBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncAntbudgetConsumedamountBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 业务活动唯一id集合
        /// </summary>
        [JsonPropertyName("biz_uk_ids")]
        public List<string> BizUkIds { get; set; }

        /// <summary>
        /// nameSpace PURCHASE/PROMO/COMMISSION
        /// </summary>
        [JsonPropertyName("ns")]
        public string Ns { get; set; }
    }
}
