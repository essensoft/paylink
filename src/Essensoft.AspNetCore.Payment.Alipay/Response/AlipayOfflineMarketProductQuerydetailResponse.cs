using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketProductQuerydetailResponse.
    /// </summary>
    public class AlipayOfflineMarketProductQuerydetailResponse : AlipayResponse
    {
        /// <summary>
        /// 商品首图，尺寸比例在65:53范围内且图片大小不超过10k皆可
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 商品描述，只有单品代金券有商品描述
        /// </summary>
        [JsonPropertyName("descriptions")]
        public List<AlipayDataItemDescription> Descriptions { get; set; }

        /// <summary>
        /// 商品下架时间，不得早于商品生效时间，商品下架
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 商品生效时间，到达生效时间后才可在客户端展示出来
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品库存数量
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 是否自动延期，默认false
        /// </summary>
        [JsonPropertyName("is_auto_expanded")]
        public bool IsAutoExpanded { get; set; }

        /// <summary>
        /// 该商品当前的状态，共有四个状态：  INIT（初始化状态）  EFFECTIVE（上架/售卖中）  PAUSE（暂停售卖）  INVALID（下架/失效状态）  说明： 处于暂停售卖状态的商品还可以变成上架/售卖中状态，但一旦INVALID就相当于删除了该商品，无法再做其他操作
        /// </summary>
        [JsonPropertyName("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 商品类型，券类型为固定值VOUCHER
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 图片集，是map转化成的json串，key是图片id,value是图片url
        /// </summary>
        [JsonPropertyName("pic_coll")]
        public string PicColl { get; set; }

        /// <summary>
        /// 商品购买类型：  OBTAIN为领取  AUTO_OBTAIN为自动领取
        /// </summary>
        [JsonPropertyName("purchase_mode")]
        public string PurchaseMode { get; set; }

        /// <summary>
        /// 销售规则，如用户一天只能领取一次等
        /// </summary>
        [JsonPropertyName("sales_rule")]
        public AlipayDataItemSalesRule SalesRule { get; set; }

        /// <summary>
        /// 上架门店id列表，即传入一个或多个shop_id，必须是创建商品partnerId下的店铺，目前支持的店铺最大100个，如果超过100个店铺需要报备
        /// </summary>
        [JsonPropertyName("shop_list")]
        public List<string> ShopList { get; set; }

        /// <summary>
        /// 商品名称，请勿超过15个汉字，30个字符
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 券模板信息
        /// </summary>
        [JsonPropertyName("voucher_templete")]
        public AlipayDataItemVoucherTemplete VoucherTemplete { get; set; }

        /// <summary>
        /// 商品顺序权重，必须是整数，不传默认为0，权重数值越大排序越靠前
        /// </summary>
        [JsonPropertyName("weight")]
        public long Weight { get; set; }
    }
}
