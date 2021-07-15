using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportCarrentalOrderSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportCarrentalOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 支付宝userid（用户在支付宝平台的2088开头16位id）
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 租车信息
        /// </summary>
        [JsonPropertyName("car_rental_info")]
        public CarRentalInfo CarRentalInfo { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 租车商品信息
        /// </summary>
        [JsonPropertyName("goods_info")]
        public CarRentalGoodsInfo GoodsInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单详情链接  链接是商户自己的小程序的
        /// </summary>
        [JsonPropertyName("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 订单扩展字段，示例展示场景：key：scene_type，value：NOTICE_TOUCH；key：cup_type，value:BRING_CUP
        /// </summary>
        [JsonPropertyName("order_extra_info")]
        public List<ExtraInfo> OrderExtraInfo { get; set; }

        /// <summary>
        /// 订单修改时间(订单更新时需有变动)
        /// </summary>
        [JsonPropertyName("order_modify_time")]
        public string OrderModifyTime { get; set; }

        /// <summary>
        /// 订单类型，枚举支持  ALIPAY_APPLETS：支付宝小程序产生的订单 ALIPAY_POS：收银POS产生的支付宝订单
        /// </summary>
        [JsonPropertyName("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 订单类型 HOUR_RENT 时租 DAY_RENT 日租 PACKAGE_RENT 套餐
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 交易支付金额
        /// </summary>
        [JsonPropertyName("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 付费类型 PRE_PAY 先付 POST_PAY 后付
        /// </summary>
        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 商户订单同步记录id（同一订单，非第一次同步 必填）
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 服务标识
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 订单枚举。 CREATE  下单成功 PAID_BEFORE_USE   取车前已支付 CANCELLED   已取消 TO_TAKE_CAR   待取车 CAR_OCCUPYING   用车中 PARTIAL_TO_BE_PAID    部分待结算 PARTIAL_PAID   部分结算支付成功 CAR_RETURNED  已还车 TO_BE_PAID   待结算 PAID_AFTER_USE   用车后已支付 REFUNDED   已退款 FINISHED   订单完成
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子服务类型  RESERVATION   预约单 INSTANT   实时单
        /// </summary>
        [JsonPropertyName("sub_service_type")]
        public string SubServiceType { get; set; }

        /// <summary>
        /// 支付宝交易号（一个订单可能存在多笔支付单，英文逗号隔开）示例：2021050622001425901452597134,2021050622001425901452597135  PAID_BEFORE_USE PARTIAL_PAID PAID_AFTER_USE REFUNDED FINISHED 状态下如果使用支付宝支付则必传
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [JsonPropertyName("vehicle_info")]
        public CarRentalVehicleInfo VehicleInfo { get; set; }
    }
}
