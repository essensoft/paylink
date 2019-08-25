using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringSmartstoreDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringSmartstoreDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 浏览过的商品，格式英文逗号分隔
        /// </summary>
        [JsonProperty("browse_dishs")]
        public string BrowseDishs { get; set; }

        /// <summary>
        /// 浏览时长，单位分钟
        /// </summary>
        [JsonProperty("browse_time")]
        public string BrowseTime { get; set; }

        /// <summary>
        /// 是否购买蛋糕，Y成功 N不成功
        /// </summary>
        [JsonProperty("buy_result")]
        public string BuyResult { get; set; }

        /// <summary>
        /// 商户开柜时间
        /// </summary>
        [JsonProperty("cabinet_open_time")]
        public string CabinetOpenTime { get; set; }

        /// <summary>
        /// 用户取餐时间
        /// </summary>
        [JsonProperty("carry_time")]
        public string CarryTime { get; set; }

        /// <summary>
        /// 送餐完成时间
        /// </summary>
        [JsonProperty("delivery_end_time")]
        public string DeliveryEndTime { get; set; }

        /// <summary>
        /// 开始送餐时间
        /// </summary>
        [JsonProperty("delivery_start_time")]
        public string DeliveryStartTime { get; set; }

        /// <summary>
        /// 留言描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 订单优惠金额，单位元
        /// </summary>
        [JsonProperty("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 子订单优惠金额，单位元
        /// </summary>
        [JsonProperty("item_discount_price")]
        public string ItemDiscountPrice { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [JsonProperty("item_order_id")]
        public string ItemOrderId { get; set; }

        /// <summary>
        /// 子订单名称
        /// </summary>
        [JsonProperty("item_order_name")]
        public string ItemOrderName { get; set; }

        /// <summary>
        /// 子订单价格，单位元
        /// </summary>
        [JsonProperty("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 子订单份数
        /// </summary>
        [JsonProperty("item_quantity")]
        public string ItemQuantity { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 主订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 开始点单时间
        /// </summary>
        [JsonProperty("order_start_time")]
        public string OrderStartTime { get; set; }

        /// <summary>
        /// 订单类型；门店堂食：dish，门店打包：pack，预约堂食：book_dish，预约打包：book_pack
        /// </summary>
        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonProperty("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付方式，微信：wechat，支付宝：alipay，现金：cash，银行卡：card，储值卡：value
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 用餐人数
        /// </summary>
        [JsonProperty("people")]
        public string People { get; set; }

        /// <summary>
        /// 识别完成时间
        /// </summary>
        [JsonProperty("recognize_end_time")]
        public string RecognizeEndTime { get; set; }

        /// <summary>
        /// 开始识别时间
        /// </summary>
        [JsonProperty("recognize_start_time")]
        public string RecognizeStartTime { get; set; }

        /// <summary>
        /// 是否识别成功，Y成功 N不成功
        /// </summary>
        [JsonProperty("recognize_succeed")]
        public string RecognizeSucceed { get; set; }

        /// <summary>
        /// 推荐菜品。格式：菜品名称，以英文逗号分隔
        /// </summary>
        [JsonProperty("recommend_dishs")]
        public string RecommendDishs { get; set; }

        /// <summary>
        /// 退款金额，单位元
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款理由
        /// </summary>
        [JsonProperty("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [JsonProperty("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 场景  点餐：dishOrder  取餐柜：diningCabinet  零售柜：retailCabinet  图像识别：imageRecognize  RFID识别：RFID  人脸识别支付：facePay  蛋糕屏：cakeScreen  送餐机器人：diningRobot
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [JsonProperty("table_number")]
        public string TableNumber { get; set; }

        /// <summary>
        /// 订单总金额，单位元
        /// </summary>
        [JsonProperty("total_price")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
