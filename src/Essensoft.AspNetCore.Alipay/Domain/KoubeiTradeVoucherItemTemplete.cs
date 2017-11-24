using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeVoucherItemTemplete Data Structure.
    /// </summary>
    public class KoubeiTradeVoucherItemTemplete : AlipayObject
    {
        /// <summary>
        /// 购买须知，列表类型，最多10项
        /// </summary>
        [JsonProperty("buyer_notes")]
        public List<KoubeiItemDescription> BuyerNotes { get; set; }

        /// <summary>
        /// 表示是否支持预定，支持“T”, 不支持“F”
        /// </summary>
        [JsonProperty("support_book")]
        public string SupportBook { get; set; }

        /// <summary>
        /// 购买有效期：商品自购买起多长时间内有效，取值范围 7-360，单位天。举例，如果是7的话，是到第七天晚上23:59:59失效。商品购买后，没有在有效期内核销，则自动退款给用户。举例：买了一个高级造型师洗剪吹的商品，有效期一个月，如果一个月之后，用户没有使用商品来进行洗剪吹的服务，则自动退款给用户。
        /// </summary>
        [JsonProperty("validity_period")]
        public string ValidityPeriod { get; set; }
    }
}
