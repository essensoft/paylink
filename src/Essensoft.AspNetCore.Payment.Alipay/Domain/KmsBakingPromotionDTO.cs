using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KmsBakingPromotionDTO Data Structure.
    /// </summary>
    public class KmsBakingPromotionDTO : AlipayObject
    {
        /// <summary>
        /// 活动限制
        /// </summary>
        [JsonPropertyName("activity_limitation")]
        public ActivityLimitationDTO ActivityLimitation { get; set; }

        /// <summary>
        /// 可用日志，周一、周二、周三、周四、周五、周六、周日。 枚举值: Monday、Tuesday、Wednesday、Thursday、Friday、Saturday、Sunday 如果有多个，用英文逗号连接。
        /// </summary>
        [JsonPropertyName("available_date")]
        public string AvailableDate { get; set; }

        /// <summary>
        /// 可用时段结束时间，格式HH:mm:ss
        /// </summary>
        [JsonPropertyName("available_end_time")]
        public string AvailableEndTime { get; set; }

        /// <summary>
        /// 可用时段开始时间，格式HH:mm:ss
        /// </summary>
        [JsonPropertyName("available_start_time")]
        public string AvailableStartTime { get; set; }

        /// <summary>
        /// 表示这条数据的唯一id，主要用于后续同步了重复数据以后去重，或者用于修复之前同步的问题数据。 建议生成规则：根据shop_id+promotion_id+operate_name+operate_time生成hash值
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 营销说明
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 营销结束时间；格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 营销互斥，取值范围为Y/N
        /// </summary>
        [JsonPropertyName("exclusive")]
        public string Exclusive { get; set; }

        /// <summary>
        /// 满折营销
        /// </summary>
        [JsonPropertyName("full_discount")]
        public FullDiscountDTO FullDiscount { get; set; }

        /// <summary>
        /// 满赠营销
        /// </summary>
        [JsonPropertyName("full_gift")]
        public FullGiftDTO FullGift { get; set; }

        /// <summary>
        /// 满减营销
        /// </summary>
        [JsonPropertyName("full_reduction")]
        public FullReductionDTO FullReduction { get; set; }

        /// <summary>
        /// 会员营销，枚举值：Y/N
        /// </summary>
        [JsonPropertyName("member_promotion")]
        public string MemberPromotion { get; set; }

        /// <summary>
        /// 操作；上架或下架 上架:upshelf；下架:offshelf
        /// </summary>
        [JsonPropertyName("operation_name")]
        public string OperationName { get; set; }

        /// <summary>
        /// 操作时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 营销渠道，取值范围为线上/线下/全渠道 线上:online；线下:offline；全渠道:allchannel;
        /// </summary>
        [JsonPropertyName("promotion_channel")]
        public string PromotionChannel { get; set; }

        /// <summary>
        /// 营销id
        /// </summary>
        [JsonPropertyName("promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// 营销名称
        /// </summary>
        [JsonPropertyName("promotion_name")]
        public string PromotionName { get; set; }

        /// <summary>
        /// 营销范围，取值范围为单品/全场 单品:single;全场:fullcourt;
        /// </summary>
        [JsonPropertyName("promotion_scope")]
        public string PromotionScope { get; set; }

        /// <summary>
        /// 营销类型，取值范围为满减/满折/特价/满赠/充值， 满减:fullreduction；满折:fulldiscount；特价:specialprice；满赠:fullgift；充值: recharge
        /// </summary>
        [JsonPropertyName("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 充值营销
        /// </summary>
        [JsonPropertyName("recharge")]
        public RechargeDTO Recharge { get; set; }

        /// <summary>
        /// 特价营销
        /// </summary>
        [JsonPropertyName("special_price")]
        public SpecialPriceDTO SpecialPrice { get; set; }

        /// <summary>
        /// 营销开始时间；格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
