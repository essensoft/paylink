using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataCustomreportDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 自定义报表的规则KEY
        /// </summary>
        [JsonProperty("condition_key")]
        public string ConditionKey { get; set; }
    }
}
