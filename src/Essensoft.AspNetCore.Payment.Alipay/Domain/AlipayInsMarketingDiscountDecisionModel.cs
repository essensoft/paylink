using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingDiscountDecisionModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingDiscountDecisionModel : AlipayObject
    {
        /// <summary>
        /// 保险营销账号Id
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 保险营销账号类型
        /// </summary>
        [JsonProperty("account_type")]
        public long AccountType { get; set; }

        /// <summary>
        /// 保险营销业务类型
        /// </summary>
        [JsonProperty("business_type")]
        public long BusinessType { get; set; }

        /// <summary>
        /// 优惠咨询因子
        /// </summary>
        [JsonProperty("factors")]
        public List<InsMktFactorDTO> Factors { get; set; }

        /// <summary>
        /// 营销市场列表
        /// </summary>
        [JsonProperty("market_types")]
        public List<long> MarketTypes { get; set; }

        /// <summary>
        /// 营销标的列表
        /// </summary>
        [JsonProperty("mkt_objects")]
        public List<InsMktObjectDTO> MktObjects { get; set; }

        /// <summary>
        /// 请求流水Id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
