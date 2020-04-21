using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StoreInfo Data Structure.
    /// </summary>
    public class StoreInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝品牌ID
        /// </summary>
        [JsonPropertyName("alipay_brand_id")]
        public string AlipayBrandId { get; set; }

        /// <summary>
        /// 支付宝运营店ID
        /// </summary>
        [JsonPropertyName("alipay_shop_id")]
        public string AlipayShopId { get; set; }

        /// <summary>
        /// 门店小程序列表
        /// </summary>
        [JsonPropertyName("app_infos")]
        public Appinfos AppInfos { get; set; }

        /// <summary>
        /// 业务码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 操作类型: 飞猪开店  0 飞猪挂接关系调整 1
        /// </summary>
        [JsonPropertyName("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 飞猪POIID
        /// </summary>
        [JsonPropertyName("fliggy_poi_id")]
        public long FliggyPoiId { get; set; }

        /// <summary>
        /// 小程序描述
        /// </summary>
        [JsonPropertyName("mini_app_desc")]
        public string MiniAppDesc { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonPropertyName("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 主账号ID
        /// </summary>
        [JsonPropertyName("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [JsonPropertyName("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 商户中心门店ID
        /// </summary>
        [JsonPropertyName("store_id")]
        public long StoreId { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [JsonPropertyName("store_status")]
        public long StoreStatus { get; set; }

        /// <summary>
        /// 子账号ID
        /// </summary>
        [JsonPropertyName("sub_seller_id")]
        public long SubSellerId { get; set; }
    }
}
