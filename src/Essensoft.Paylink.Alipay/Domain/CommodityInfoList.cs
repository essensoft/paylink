using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CommodityInfoList Data Structure.
    /// </summary>
    public class CommodityInfoList : AlipayObject
    {
        /// <summary>
        /// 品类生效地区码
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 基础面额，单位为分
        /// </summary>
        [JsonPropertyName("basic_amount")]
        public string BasicAmount { get; set; }

        /// <summary>
        /// 特殊面额（一般为权益金）
        /// </summary>
        [JsonPropertyName("benefit_amout")]
        public string BenefitAmout { get; set; }

        /// <summary>
        /// 品类类目枚举，平台映射
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 品类型（储值方案、商品、权益方案）由平台分配
        /// </summary>
        [JsonPropertyName("commodity_type")]
        public string CommodityType { get; set; }

        /// <summary>
        /// 关联用户数量
        /// </summary>
        [JsonPropertyName("customer_amount")]
        public string CustomerAmount { get; set; }

        /// <summary>
        /// 商品跳转链接
        /// </summary>
        [JsonPropertyName("directing_url")]
        public string DirectingUrl { get; set; }

        /// <summary>
        /// 展示图片地址
        /// </summary>
        [JsonPropertyName("display_img_url")]
        public string DisplayImgUrl { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("inventory")]
        public string Inventory { get; set; }

        /// <summary>
        /// 月销量
        /// </summary>
        [JsonPropertyName("monthly_sale")]
        public string MonthlySale { get; set; }

        /// <summary>
        /// 外部资源品类的id（长度<128）
        /// </summary>
        [JsonPropertyName("out_commodity_id")]
        public string OutCommodityId { get; set; }

        /// <summary>
        /// 生效日期（Date类型）
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// A、U，生效、失效状态，为枚举值
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 品类二级类目枚举，平台映射
        /// </summary>
        [JsonPropertyName("sub_category")]
        public string SubCategory { get; set; }

        /// <summary>
        /// 标签列表，需要映射到平台的标签，否则无法处理，联系平台添加
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 总销量
        /// </summary>
        [JsonPropertyName("total_sale")]
        public string TotalSale { get; set; }
    }
}
