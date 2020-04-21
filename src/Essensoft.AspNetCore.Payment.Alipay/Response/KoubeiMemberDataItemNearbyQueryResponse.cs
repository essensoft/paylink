using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMemberDataItemNearbyQueryResponse.
    /// </summary>
    public class KoubeiMemberDataItemNearbyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 附近优惠商品列表,前端根据其中的字段展示即可
        /// </summary>
        [JsonPropertyName("goods_list")]
        public List<NearbyGoods> GoodsList { get; set; }

        /// <summary>
        /// 是否有下一页,用于分页展示
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 下页数据开始索引，请求下一页时作为请求参数start上传。
        /// </summary>
        [JsonPropertyName("next_start")]
        public long NextStart { get; set; }
    }
}
