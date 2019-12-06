using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingToolIsvMerchantQueryResponse.
    /// </summary>
    public class KoubeiMarketingToolIsvMerchantQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户信息列表
        /// </summary>
        [JsonPropertyName("merchant_infos")]
        public List<IsvMerchantInfo> MerchantInfos { get; set; }

        /// <summary>
        /// 门店总量
        /// </summary>
        [JsonPropertyName("shop_count")]
        public string ShopCount { get; set; }

        /// <summary>
        /// 门店详情列表信息
        /// </summary>
        [JsonPropertyName("shop_summary_infos")]
        public List<ShopSummaryInfo> ShopSummaryInfos { get; set; }
    }
}
