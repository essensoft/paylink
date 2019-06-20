using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 订单向下调整金额
        /// </summary>
        [JsonProperty("adjust_amount")]
        public string AdjustAmount { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// "可枚举的业务产品类型  (1)KB_ORDER_DISHES 立即就餐  (2) KB_RESERVATION 预约点餐"
        /// </summary>
        [JsonProperty("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 可枚举的业务类型。  DINNER：正餐；  SNACK：快餐；
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 可枚举的就餐方式。  FOR_HERE：堂食；  TAKE_OUT：外卖；  TO_GO：外带
        /// </summary>
        [JsonProperty("dinner_type")]
        public string DinnerType { get; set; }

        /// <summary>
        /// 订单优惠金额；  包括但不限于：  (1) 单品优惠；  (2) 订单满减优惠；
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单优惠明细信息，包括优惠名称及对应的优惠金额；
        /// </summary>
        [JsonProperty("discount_infos")]
        public List<DiscountInfos> DiscountInfos { get; set; }

        /// <summary>
        /// 菜品金额之和
        /// </summary>
        [JsonProperty("dish_amount")]
        public string DishAmount { get; set; }

        /// <summary>
        /// 菜品明细列表
        /// </summary>
        [JsonProperty("dish_list")]
        public List<DishList> DishList { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 在线支付金额
        /// </summary>
        [JsonProperty("koubei_payment_amount")]
        public string KoubeiPaymentAmount { get; set; }

        /// <summary>
        /// POS支付的金额，为POS侧支付成功的订单金额之和；
        /// </summary>
        [JsonProperty("offline_payment_amount")]
        public string OfflinePaymentAmount { get; set; }

        /// <summary>
        /// 口碑的订单号，口碑推单时传入  特别说明：  (1)在POS侧未做任何接单线上推单前，这个值可能为空；比如，收银员开台并点菜；  (2)在POS侧接单后，口碑订单号写入POS侧；本服务查询时，需要能回传给口碑；
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 可枚举的点餐方式。  POS：pos点餐；  SCAN：扫码点菜；  PLATFORM：平台(外卖类的)
        /// </summary>
        [JsonProperty("order_style")]
        public string OrderStyle { get; set; }

        /// <summary>
        /// 2018-01-29 10:00:00
        /// </summary>
        [JsonProperty("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 其他可打折的金额
        /// </summary>
        [JsonProperty("other_amount_discountable")]
        public string OtherAmountDiscountable { get; set; }

        /// <summary>
        /// 对其他金额的详细说明；表达服务费、餐台费等各种费用具体的金额。
        /// </summary>
        [JsonProperty("other_amount_infos")]
        public List<OtherAmountInfos> OtherAmountInfos { get; set; }

        /// <summary>
        /// 其他不可打折的金额
        /// </summary>
        [JsonProperty("other_amount_undiscountable")]
        public string OtherAmountUndiscountable { get; set; }

        /// <summary>
        /// POS订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付类型。  ADVANCE_PAYMENT：先付；  AFTER_PAYMENT：后付；
        /// </summary>
        [JsonProperty("pay_style")]
        public string PayStyle { get; set; }

        /// <summary>
        /// 支付信息
        /// </summary>
        [JsonProperty("payment_list")]
        public List<PaymentList> PaymentList { get; set; }

        /// <summary>
        /// 就餐人数
        /// </summary>
        [JsonProperty("people_num")]
        public long PeopleNum { get; set; }

        /// <summary>
        /// POS订单的版本，用于控制POS与口碑订单信息同步，避免乱序的控制机制。  特别说明：  POS侧订单信息的变化都应该能反映到订单版本中。必须保证递增
        /// </summary>
        [JsonProperty("pos_version")]
        public long PosVersion { get; set; }

        /// <summary>
        /// 订单应收金额
        /// </summary>
        [JsonProperty("receivable_amount")]
        public string ReceivableAmount { get; set; }

        /// <summary>
        /// 退款信息
        /// </summary>
        [JsonProperty("refund_list")]
        public List<RefundList> RefundList { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// "可枚举的订单状态：  WAIT_PAY: 待支付  SUCCESS: 结账   FINISH: 反结  CLOSE: 关单"
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 就餐的餐台号码
        /// </summary>
        [JsonProperty("table_no")]
        public string TableNo { get; set; }

        /// <summary>
        /// 订单累计已支付金额
        /// </summary>
        [JsonProperty("total_paymented_amount")]
        public string TotalPaymentedAmount { get; set; }

        /// <summary>
        /// 是否使用线上优惠的标记  (1) Y : 这是默认选项；这种情况下，订单级优惠均可使用；  (2) N：当POS侧设置了手工优惠或者其他场景不希望使用线上订单级优惠的时候，设置此标识；  此字段的使用主要是规避商家重复出优惠的问题。
        /// </summary>
        [JsonProperty("use_online_promotion_flag")]
        public string UseOnlinePromotionFlag { get; set; }
    }
}
