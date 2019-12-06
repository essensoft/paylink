using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportSaveResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportSaveResponse : AlipayResponse
    {
        /// <summary>
        /// 自定义报表的规则ID
        /// </summary>
        [JsonPropertyName("condition_key")]
        public string ConditionKey { get; set; }
    }
}
