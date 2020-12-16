using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemVO Data Structure.
    /// </summary>
    public class ItemVO : AlipayObject
    {
        /// <summary>
        /// 条形码信息，应用于扫一扫场景
        /// </summary>
        [JsonPropertyName("barcode_info")]
        public BarcodeInfoVO BarcodeInfo { get; set; }

        /// <summary>
        /// 能否被搜索，可被搜索（true）,不可被搜索（false），默认true可以被搜索
        /// </summary>
        [JsonPropertyName("can_be_search")]
        public string CanBeSearch { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品特征json字符串
        /// </summary>
        [JsonPropertyName("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// 详情图url列表，不超过3个图片
        /// </summary>
        [JsonPropertyName("image_list")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 商家侧商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [JsonPropertyName("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 商品原价，分为单位
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 平台类目
        /// </summary>
        [JsonPropertyName("platform_category")]
        public ItemCategoryVO PlatformCategory { get; set; }

        /// <summary>
        /// 平台侧商品id
        /// </summary>
        [JsonPropertyName("platform_item_id")]
        public string PlatformItemId { get; set; }

        /// <summary>
        /// 商品价格，分为单位
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品详情页URL
        /// </summary>
        [JsonPropertyName("src_path")]
        public string SrcPath { get; set; }

        /// <summary>
        /// 商品售卖状态，售罄(SOLD_OUT),冻结(FREEZE) 可售(AVAILABLE)
        /// </summary>
        [JsonPropertyName("stock_status")]
        public string StockStatus { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
