using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingDiscountDecisionModel Data Structure.
    /// </summary>
    public class AlipayInsMarketingDiscountDecisionModel : AlipayObject
    {
        /// <summary>
        /// 保险营销账号Id
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 保险营销账号类型
        /// </summary>
        [JsonPropertyName("account_type")]
        public long AccountType { get; set; }

        /// <summary>
        /// 保险营销业务类型
        /// </summary>
        [JsonPropertyName("business_type")]
        public long BusinessType { get; set; }

        /// <summary>
        /// 优惠咨询因子
        /// </summary>
        [JsonPropertyName("factors")]
        public List<InsMktFactorDTO> Factors { get; set; }

        /// <summary>
        /// 营销市场列表
        /// </summary>
        [JsonPropertyName("market_types")]
        public List<long> MarketTypes { get; set; }

        /// <summary>
        /// 营销标的列表
        /// </summary>
        [JsonPropertyName("mkt_objects")]
        public List<InsMktObjectDTO> MktObjects { get; set; }

        /// <summary>
        /// 请求流水Id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
