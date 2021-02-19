using System.Text.Json.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeServiceRecommendbankQueryResponse.
    /// </summary>
    public class AlipayTradeServiceRecommendbankQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 推荐银行列表,包含iosSchama,安卓Schama等信息
        /// </summary>
        [JsonPropertyName("recommend_bank_infos")]
        public List<RecommendBankInfo> RecommendBankInfos { get; set; }
    }
}
