using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CarRentalGoodsInfo Data Structure.
    /// </summary>
    public class CarRentalGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 商品扩展字段
        /// </summary>
        [JsonPropertyName("goods_extra_info")]
        public List<ExtraInfo> GoodsExtraInfo { get; set; }

        /// <summary>
        /// 商品列表信息
        /// </summary>
        [JsonPropertyName("goods_list")]
        public List<CarRentalGoods> GoodsList { get; set; }
    }
}
