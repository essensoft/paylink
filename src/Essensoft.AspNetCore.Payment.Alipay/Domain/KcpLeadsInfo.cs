using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KcpLeadsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KcpLeadsInfo : AlipayObject
    {
        /// <summary>
        /// 购买须知
        /// </summary>
        [JsonProperty("buy_tips")]
        public string BuyTips { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [JsonProperty("comment_count")]
        public string CommentCount { get; set; }

        /// <summary>
        /// 和友商比较标签
        /// </summary>
        [JsonProperty("compare_label")]
        public string CompareLabel { get; set; }

        /// <summary>
        /// 友商商品唯一id
        /// </summary>
        [JsonProperty("deal_id")]
        public string DealId { get; set; }

        /// <summary>
        /// 菜品列表
        /// </summary>
        [JsonProperty("dish_list")]
        public string DishList { get; set; }

        /// <summary>
        /// 商品有效期
        /// </summary>
        [JsonProperty("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 行业类型，CATERING餐饮，SERV_INDUSTRY泛行业
        /// </summary>
        [JsonProperty("industry_type")]
        public string IndustryType { get; set; }

        /// <summary>
        /// 适用的友商门店id
        /// </summary>
        [JsonProperty("jd_shop_id")]
        public string JdShopId { get; set; }

        /// <summary>
        /// 门店列表
        /// </summary>
        [JsonProperty("kb_shop_ids")]
        public List<string> KbShopIds { get; set; }

        /// <summary>
        /// leadsid
        /// </summary>
        [JsonProperty("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 满减描述
        /// </summary>
        [JsonProperty("minus_description")]
        public string MinusDescription { get; set; }

        /// <summary>
        /// 价格信息
        /// </summary>
        [JsonProperty("price_rule")]
        public string PriceRule { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        [JsonProperty("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [JsonProperty("sales")]
        public string Sales { get; set; }

        /// <summary>
        /// 评价标签
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// leads类型，ITEM商品，VOUCHER代金券
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 不可用日期
        /// </summary>
        [JsonProperty("unvalidate_info")]
        public string UnvalidateInfo { get; set; }

        /// <summary>
        /// 适用时段
        /// </summary>
        [JsonProperty("valitime_info")]
        public string ValitimeInfo { get; set; }

        /// <summary>
        /// leads版本，1：新版本；2：老版本
        /// </summary>
        [JsonProperty("ver")]
        public string Ver { get; set; }
    }
}
