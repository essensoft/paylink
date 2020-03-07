using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideSyncResponse.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 单次上传交易数据失败条数数量
        /// </summary>
        [JsonPropertyName("failure_count")]
        public long FailureCount { get; set; }

        /// <summary>
        /// 非法交易列表，上传数据如果校验不通过，则放入该列表中返回给isv。如果全部通过，则该列表为空
        /// </summary>
        [JsonPropertyName("invalid_trade_details")]
        public List<InvalidTradeDetail> InvalidTradeDetails { get; set; }

        /// <summary>
        /// 单次上传交易数据校验成功的数量
        /// </summary>
        [JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
