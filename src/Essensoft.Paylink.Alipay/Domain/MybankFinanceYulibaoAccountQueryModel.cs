using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryModel Data Structure.
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金代码。余利宝场景固定为 001529。
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }
    }
}
