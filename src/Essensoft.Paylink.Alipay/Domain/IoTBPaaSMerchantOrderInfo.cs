using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// IoTBPaaSMerchantOrderInfo Data Structure.
    /// </summary>
    public class IoTBPaaSMerchantOrderInfo : AlipayObject
    {
        /// <summary>
        /// 优惠活动信息列表
        /// </summary>
        [JsonPropertyName("activity_item_list")]
        public List<IoTBPaaSMerchantOrderItemInfo> ActivityItemList { get; set; }

        /// <summary>
        /// 外送费
        /// </summary>
        [JsonPropertyName("courier_fee")]
        public string CourierFee { get; set; }

        /// <summary>
        /// 顾客性别
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 外送地址,外卖订单才有
        /// </summary>
        [JsonPropertyName("order_address")]
        public string OrderAddress { get; set; }

        /// <summary>
        /// 买家联系方式,外卖订单才有
        /// </summary>
        [JsonPropertyName("order_contact")]
        public string OrderContact { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonPropertyName("order_item_list")]
        public List<IoTBPaaSMerchantOrderItemInfo> OrderItemList { get; set; }

        /// <summary>
        /// 商品总数量
        /// </summary>
        [JsonPropertyName("order_item_total_quantity")]
        public string OrderItemTotalQuantity { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonPropertyName("order_memo")]
        public string OrderMemo { get; set; }

        /// <summary>
        /// 取餐号
        /// </summary>
        [JsonPropertyName("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 订单总价
        /// </summary>
        [JsonPropertyName("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 订单实际价格
        /// </summary>
        [JsonPropertyName("order_real_price")]
        public string OrderRealPrice { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 到店订单类型:SHOP_SERVICE 到家订单类型:HOME_SERVICE
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 打包费
        /// </summary>
        [JsonPropertyName("package_fee")]
        public string PackageFee { get; set; }

        /// <summary>
        /// 必填信息
        /// </summary>
        [JsonPropertyName("require_info_list")]
        public List<IoTBPaaSMerchantOrderRequireInfo> RequireInfoList { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 顾客姓名,脱敏处理
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
