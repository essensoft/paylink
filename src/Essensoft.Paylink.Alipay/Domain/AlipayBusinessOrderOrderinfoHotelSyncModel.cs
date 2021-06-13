using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessOrderOrderinfoHotelSyncModel Data Structure.
    /// </summary>
    public class AlipayBusinessOrderOrderinfoHotelSyncModel : AlipayObject
    {
        /// <summary>
        /// 订单总金额（不包含任何优惠的金额）
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 酒店小程序id
        /// </summary>
        [JsonPropertyName("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 预定人信息
        /// </summary>
        [JsonPropertyName("booker")]
        public Passenger Booker { get; set; }

        /// <summary>
        /// 取消规则描述
        /// </summary>
        [JsonPropertyName("cancel_rule_description")]
        public string CancelRuleDescription { get; set; }

        /// <summary>
        /// 取消规则
        /// </summary>
        [JsonPropertyName("cancel_rule_name")]
        public string CancelRuleName { get; set; }

        /// <summary>
        /// 入住日期
        /// </summary>
        [JsonPropertyName("check_in_date")]
        public string CheckInDate { get; set; }

        /// <summary>
        /// 酒店入住时间
        /// </summary>
        [JsonPropertyName("check_in_time")]
        public string CheckInTime { get; set; }

        /// <summary>
        /// 离店日期
        /// </summary>
        [JsonPropertyName("check_out_date")]
        public string CheckOutDate { get; set; }

        /// <summary>
        /// 酒店离店时间
        /// </summary>
        [JsonPropertyName("check_out_time")]
        public string CheckOutTime { get; set; }

        /// <summary>
        /// 订单优惠金额（仅包含外券优惠金额，即仅包含商户优惠的金额，不包含支付宝优惠的金额（如支付宝红包等））
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 会员卡支付宝卡包模板id
        /// </summary>
        [JsonPropertyName("membership_card_template_id")]
        public string MembershipCardTemplateId { get; set; }

        /// <summary>
        /// 会员卡等级枚举值
        /// </summary>
        [JsonPropertyName("membership_grade")]
        public string MembershipGrade { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 支付宝订单id，订单同步。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝小程序订单详情页链接
        /// </summary>
        [JsonPropertyName("order_link")]
        public string OrderLink { get; set; }

        /// <summary>
        /// 来源ISV
        /// </summary>
        [JsonPropertyName("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 订单状态： ORDER_SUCCESS--下单成功 TO_BE_PAID--待支付 PAID--已支付 TO_CHECK_IN--待入住 CHECKED_IN--已入住 CHECKED_OUT--已退房 FINISHED--订单完成 CANCELING--订单取消中 CANCELED--订单取消 CLOSED--订单关闭
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单更新时间
        /// </summary>
        [JsonPropertyName("order_update_time")]
        public string OrderUpdateTime { get; set; }

        /// <summary>
        /// 商户侧酒店id
        /// </summary>
        [JsonPropertyName("outer_hotel_id")]
        public string OuterHotelId { get; set; }

        /// <summary>
        /// ISV订单id
        /// </summary>
        [JsonPropertyName("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 收款账户pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 预约到店时间
        /// </summary>
        [JsonPropertyName("plan_check_in_date")]
        public string PlanCheckInDate { get; set; }

        /// <summary>
        /// 房型信息
        /// </summary>
        [JsonPropertyName("rooms")]
        public List<Room> Rooms { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 下单用户id
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
