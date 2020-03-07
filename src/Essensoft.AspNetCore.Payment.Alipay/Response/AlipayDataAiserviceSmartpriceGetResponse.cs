using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceSmartpriceGetResponse.
    /// </summary>
    public class AlipayDataAiserviceSmartpriceGetResponse : AlipayResponse
    {
        /// <summary>
        /// 兼容V1.0。用户购买hellobike月卡的推荐价格，单位为分。
        /// </summary>
        [JsonPropertyName("promo_price_cent")]
        public long PromoPriceCent { get; set; }

        /// <summary>
        /// 返回结果列表
        /// </summary>
        [JsonPropertyName("result")]
        public List<HelloBikePriceResultItem> Result { get; set; }
    }
}
