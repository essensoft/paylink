using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemQueryResponse Data Structure.
    /// </summary>
    public class ItemQueryResponse : AlipayObject
    {
        /// <summary>
        /// 口碑商品所属的后台类目id，后台类目数据来源：开放接口koubei.item.category.children.batchquery（查询后台类目树接口）
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 首图
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 商品描述，列表类型，每一项的key，value的描述见下面两行
        /// </summary>
        [JsonPropertyName("descriptions")]
        public List<KoubeiItemDescription> Descriptions { get; set; }

        /// <summary>
        /// 售卖结束时间。当到达该时间时，商品暂停售卖，将不在客户端中继续展示，用户无法继续购买。  注意：该时间不能晚于核销绝对有效期的结束时间。
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 商品售卖开始时间，商品状态有效并且到达生效时间后才可在客户端（消费者端）展示出来，如果商品生效时间小于当前时间，则立即生效。  说明： 商品的生效时间不能早于创建当天的0点
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 当前库存
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 该商品当前的状态，共有5个状态：INIT（初始状态）EFFECTIVE（生效）PAUSE（暂停）FREEZE(冻结)INVALID（失效）；详见状态变更图
        /// </summary>
        [JsonPropertyName("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 商品类型，交易凭证类：TRADE_VOUCHER
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 标准商品为原价，必填。非标准商品请勿填写，填写无效。价格单位为元
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 图片集，本商品所有图片id和URL的对应关系数组
        /// </summary>
        [JsonPropertyName("pic_coll")]
        public List<string> PicColl { get; set; }

        /// <summary>
        /// 商品详情图，多张图片以英文逗号分隔
        /// </summary>
        [JsonPropertyName("picture_details")]
        public string PictureDetails { get; set; }

        /// <summary>
        /// 标准商品为现价,选填。非标准商品为最小价格（非标商品为xx元起）必填。价格单位为元。如果标准商品现价不填写，则以原价进行售卖；如果现价与原价相等时，则会以原价售卖，并且客户端只展示一个价格（原价）
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 标准商品:FIX；非标准商品:FLOAT ，根据该字段判断商品是标准商品或非标商品。
        /// </summary>
        [JsonPropertyName("price_mode")]
        public string PriceMode { get; set; }

        /// <summary>
        /// 适用门店列表
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public string ShopIds { get; set; }

        /// <summary>
        /// 商品名称，不超过20汉字，40个字符
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 淘宝首图
        /// </summary>
        [JsonPropertyName("tb_cover")]
        public string TbCover { get; set; }

        /// <summary>
        /// 交易凭证类商品模板信息
        /// </summary>
        [JsonPropertyName("trade_voucher_item_template")]
        public KoubeiTradeVoucherItemTemplete TradeVoucherItemTemplate { get; set; }

        /// <summary>
        /// 商品顺序权重
        /// </summary>
        [JsonPropertyName("weight")]
        public long Weight { get; set; }
    }
}
