using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KcpLeadsInfo Data Structure.
    /// </summary>
    public class KcpLeadsInfo : AlipayObject
    {
        /// <summary>
        /// 购买须知
        /// </summary>
        [JsonPropertyName("buy_tips")]
        public string BuyTips { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [JsonPropertyName("comment_count")]
        public string CommentCount { get; set; }

        /// <summary>
        /// 和友商比较标签
        /// </summary>
        [JsonPropertyName("compare_label")]
        public string CompareLabel { get; set; }

        /// <summary>
        /// 友商商品唯一id
        /// </summary>
        [JsonPropertyName("deal_id")]
        public string DealId { get; set; }

        /// <summary>
        /// 菜品列表
        /// </summary>
        [JsonPropertyName("dish_list")]
        public string DishList { get; set; }

        /// <summary>
        /// 商品有效期
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 行业类型，CATERING餐饮，SERV_INDUSTRY泛行业
        /// </summary>
        [JsonPropertyName("industry_type")]
        public string IndustryType { get; set; }

        /// <summary>
        /// 适用的友商门店id
        /// </summary>
        [JsonPropertyName("jd_shop_id")]
        public string JdShopId { get; set; }

        /// <summary>
        /// 门店列表
        /// </summary>
        [JsonPropertyName("kb_shop_ids")]
        public List<string> KbShopIds { get; set; }

        /// <summary>
        /// leadsid
        /// </summary>
        [JsonPropertyName("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 满减描述
        /// </summary>
        [JsonPropertyName("minus_description")]
        public string MinusDescription { get; set; }

        /// <summary>
        /// 价格信息
        /// </summary>
        [JsonPropertyName("price_rule")]
        public string PriceRule { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [JsonPropertyName("sales")]
        public string Sales { get; set; }

        /// <summary>
        /// 评价标签
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// leads类型，ITEM商品，VOUCHER代金券
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 不可用日期
        /// </summary>
        [JsonPropertyName("unvalidate_info")]
        public string UnvalidateInfo { get; set; }

        /// <summary>
        /// 适用时段
        /// </summary>
        [JsonPropertyName("valitime_info")]
        public string ValitimeInfo { get; set; }

        /// <summary>
        /// leads版本，1：新版本；2：老版本
        /// </summary>
        [JsonPropertyName("ver")]
        public string Ver { get; set; }
    }
}
