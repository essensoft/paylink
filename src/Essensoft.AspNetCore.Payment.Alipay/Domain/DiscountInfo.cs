using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountInfo : AlipayObject
    {
        /// <summary>
        /// 全场代金的使用门槛
        /// </summary>
        [JsonProperty("apply_condition")]
        [XmlElement("apply_condition")]
        public string ApplyCondition { get; set; }

        /// <summary>
        /// 买M送N的描述
        /// </summary>
        [JsonProperty("buy_send_desc")]
        [XmlElement("buy_send_desc")]
        public string BuySendDesc { get; set; }

        /// <summary>
        /// 折扣率  仅当券类型为折扣券时有效  有效折扣率取值范围0.11-0.99  仅允许保留小数点后两位
        /// </summary>
        [JsonProperty("discount")]
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 优惠说明信息
        /// </summary>
        [JsonProperty("discount_notes")]
        [XmlArray("discount_notes")]
        [XmlArrayItem("voucher_desc_detail_model")]
        public List<VoucherDescDetailModel> DiscountNotes { get; set; }

        /// <summary>
        /// 最近店铺离当前用户的距离
        /// </summary>
        [JsonProperty("distance")]
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 优惠券停止发放的时间，和发放的优惠券的有效期不同
        /// </summary>
        [JsonProperty("end_time")]
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 优惠券的logo图片地址
        /// </summary>
        [JsonProperty("image_url")]
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 优惠id，调用发券接口时，需要提供“优惠id”
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 优惠券的名称
        /// </summary>
        [JsonProperty("item_name")]
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品的一些标签
        /// </summary>
        [JsonProperty("label")]
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 减至券的原价
        /// </summary>
        [JsonProperty("original_price")]
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 满减券的券面额，当每满减券(vol_type=mei_man_jian)时有效  每满thresholdPrice元减perPrice元，封顶topPrice元
        /// </summary>
        [JsonProperty("per_price")]
        [XmlElement("per_price")]
        public string PerPrice { get; set; }

        /// <summary>
        /// 发券商户ID
        /// </summary>
        [JsonProperty("pid")]
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 当券类型是全场及单品代金券的时候，这个字段代表券面额；  当券类型是减至券的时候，这个字段代表减至到的金额
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 券推荐语
        /// </summary>
        [JsonProperty("reason")]
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 买A送B中，B的描述
        /// </summary>
        [JsonProperty("send_item_name")]
        [XmlElement("send_item_name")]
        public string SendItemName { get; set; }

        /// <summary>
        /// 离用户经纬度最近的优惠券适用门店id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 优惠券的主店铺名
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 优惠券的已领数
        /// </summary>
        [JsonProperty("sold")]
        [XmlElement("sold")]
        public string Sold { get; set; }

        /// <summary>
        /// 优惠券发放的开始时间，和发放的优惠券的有效期不同
        /// </summary>
        [JsonProperty("start_time")]
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 满减券门槛，当每满减券时有效（vol_type=mei_man_jian)  每满thresholdPrice元减perPrice元，封顶topPrice元
        /// </summary>
        [JsonProperty("threshold_price")]
        [XmlElement("threshold_price")]
        public string ThresholdPrice { get; set; }

        /// <summary>
        /// 封顶金额，当每满减券(vol_type=mei_man_jian)时有效。每满减用的字段：每满thresholdPrice元减perPrice元，封顶topPrice元
        /// </summary>
        [JsonProperty("top_price")]
        [XmlElement("top_price")]
        public string TopPrice { get; set; }

        /// <summary>
        /// 优惠券类型  discount:折扣券;  cash:代金券;  exchange:兑换券;  limit_reduce_cash:减至券
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券相对有效期，券自领取或者购买起多长时间内有效，取值范围 7-360，单位天
        /// </summary>
        [JsonProperty("validity_period")]
        [XmlElement("validity_period")]
        public string ValidityPeriod { get; set; }

        /// <summary>
        /// 核销绝对有效期开始时间。自该时间点起，券可被核销。  注意：券的开始发放时段开始时间（gmt_start）不能晚于该时间。
        /// </summary>
        [JsonProperty("validity_period_range_from")]
        [XmlElement("validity_period_range_from")]
        public string ValidityPeriodRangeFrom { get; set; }

        /// <summary>
        /// 核销绝对有效期结束时间。自该时间点起，券无法继续被核销。
        /// </summary>
        [JsonProperty("validity_period_range_to")]
        [XmlElement("validity_period_range_to")]
        public string ValidityPeriodRangeTo { get; set; }

        /// <summary>
        /// 有效期类型。支持相对有效期及绝对有效期两种方式，  RELATIVE:相对有效期  FIXED:绝对有效期  相对有效期指领取或者自购买之日起XX天有效，绝对有效期指某一端固定时间内有效。
        /// </summary>
        [JsonProperty("validity_period_type")]
        [XmlElement("validity_period_type")]
        public string ValidityPeriodType { get; set; }

        /// <summary>
        /// 优惠券二级类型，  all_discount:全场折扣;  single_discount:单品折扣;  all_cash:全场代金;  single_cash：单品代金  mei_man_jian：每满减券
        /// </summary>
        [JsonProperty("vol_type")]
        [XmlElement("vol_type")]
        public string VolType { get; set; }
    }
}
