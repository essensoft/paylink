using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallDiscountQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMallDiscountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 集卡信息列表（最多50条）
        /// </summary>
        [JsonPropertyName("card_list")]
        public List<CardInfo> CardList { get; set; }

        /// <summary>
        /// 口令信息列表（最多50条）
        /// </summary>
        [JsonPropertyName("code_coupon_list")]
        public List<CodeCouponInfo> CodeCouponList { get; set; }

        /// <summary>
        /// 消费送信息列表（最多50条）
        /// </summary>
        [JsonPropertyName("consume_list")]
        public List<ConsumeInfo> ConsumeList { get; set; }

        /// <summary>
        /// 订单优惠信息列表（最多50条）
        /// </summary>
        [JsonPropertyName("reduce_list")]
        public List<ReduceInfo> ReduceList { get; set; }
    }
}
