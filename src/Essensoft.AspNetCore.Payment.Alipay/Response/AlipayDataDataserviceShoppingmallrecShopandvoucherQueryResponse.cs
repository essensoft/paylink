using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceShoppingmallrecShopandvoucherQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceShoppingmallrecShopandvoucherQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 本次推荐的id, 开发者埋点需带入此参数
        /// </summary>
        [JsonPropertyName("recommend_id")]
        public string RecommendId { get; set; }

        /// <summary>
        /// 本次请求的全局唯一标识, 支持英文字母和数字, 由开发者自行定义,和入参request_id一致
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 推荐商铺列表
        /// </summary>
        [JsonPropertyName("shop_recommend_list")]
        public List<ShopRec> ShopRecommendList { get; set; }

        /// <summary>
        /// 券推荐列表
        /// </summary>
        [JsonPropertyName("voucher_recommend_list")]
        public List<VoucherRec> VoucherRecommendList { get; set; }
    }
}
