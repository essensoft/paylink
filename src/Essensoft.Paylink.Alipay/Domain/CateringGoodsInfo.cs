using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CateringGoodsInfo Data Structure.
    /// </summary>
    public class CateringGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 商品扩展字段，商品信息扩展，key：good_ classification，value：drink
        /// </summary>
        [JsonPropertyName("goods_extra_info")]
        public List<ExtraInfo> GoodsExtraInfo { get; set; }

        /// <summary>
        /// 商品列表信息
        /// </summary>
        [JsonPropertyName("goods_list")]
        public List<Goods> GoodsList { get; set; }
    }
}
