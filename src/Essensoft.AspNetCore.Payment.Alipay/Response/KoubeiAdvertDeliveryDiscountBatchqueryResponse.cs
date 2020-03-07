using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 广告投放出去的商品信息
        /// </summary>
        [JsonPropertyName("discounts")]
        public List<DiscountInfo> Discounts { get; set; }

        /// <summary>
        /// 券领取结果
        /// </summary>
        [JsonPropertyName("purchase_datas")]
        public KbAdvertIdentifyResponse PurchaseDatas { get; set; }

        /// <summary>
        /// 本次推荐的唯一标识
        /// </summary>
        [JsonPropertyName("recommend_id")]
        public string RecommendId { get; set; }
    }
}
