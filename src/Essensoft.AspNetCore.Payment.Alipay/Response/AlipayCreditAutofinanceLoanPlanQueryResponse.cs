using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceLoanPlanQueryResponse.
    /// </summary>
    public class AlipayCreditAutofinanceLoanPlanQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款方案列表，是一个List结构,针对不同的业务平台有不同的返回值，目前大搜车业务只支持的返回值有：firstpayamt 首付租金，firstpayprop 首付比例，lastpayamt 回购尾款，loantenor 贷款期数，monthpayamt 每月还款额度
        /// </summary>
        [JsonPropertyName("loanplan")]
        public string Loanplan { get; set; }
    }
}
