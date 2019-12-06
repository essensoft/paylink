using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaintainBizOrderGoods Data Structure.
    /// </summary>
    public class MaintainBizOrderGoods : AlipayObject
    {
        /// <summary>
        /// 商品图片地址，下单时记录的商品图片
        /// </summary>
        [JsonPropertyName("goods_image")]
        public string GoodsImage { get; set; }

        /// <summary>
        /// 车主平台商品子订单id。保养订单对应商品子订单表id
        /// </summary>
        [JsonPropertyName("order_goods_id")]
        public string OrderGoodsId { get; set; }

        /// <summary>
        /// 原始价格，下单时商品的原始价格。金额单位(元)，保留两位小数。
        /// </summary>
        [JsonPropertyName("original_cost")]
        public string OriginalCost { get; set; }

        /// <summary>
        /// 外部商品编码
        /// </summary>
        [JsonPropertyName("out_goods_no")]
        public string OutGoodsNo { get; set; }

        /// <summary>
        /// 外部商品套餐唯一标示。下单时记录的ISV端商品套餐主键
        /// </summary>
        [JsonPropertyName("out_package_id")]
        public string OutPackageId { get; set; }

        /// <summary>
        /// 外部套餐名称。下单时记录的商品套餐名称，在商品详情页时透出显示
        /// </summary>
        [JsonPropertyName("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 销售价格，下单时商品的销售价格。金额单位(元)，保留两位小数。
        /// </summary>
        [JsonPropertyName("real_cost")]
        public string RealCost { get; set; }

        /// <summary>
        /// 商品购买数量
        /// </summary>
        [JsonPropertyName("sale_num")]
        public long SaleNum { get; set; }
    }
}
