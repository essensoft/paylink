using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOrderDataOpenapiResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOrderDataOpenapiResultInfo : AlipayObject
    {
        /// <summary>
        /// 订单金额，单位为元
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务号列表  注：biz_type目前仅支持"TRADE_NO"
        /// </summary>
        [JsonProperty("biz_no_list")]
        public List<string> BizNoList { get; set; }

        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 订单优惠金额
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 具体已开放平台文档为准，若无，则目前不存在扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单支付时间  若订单还未支付，则该字段为空
        /// </summary>
        [JsonProperty("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonProperty("item_list")]
        public List<ItemOrderInfoResult> ItemList { get; set; }

        /// <summary>
        /// 订单物流信息列表
        /// </summary>
        [JsonProperty("logistics_info_list")]
        public List<OrderLogisticsInformation> LogisticsInfoList { get; set; }

        /// <summary>
        /// 商户订单链接地址
        /// </summary>
        [JsonProperty("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 商户的uid，即所需查询订单的partnerId
        /// </summary>
        [JsonProperty("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 支付宝小程序订单详情地址链接
        /// </summary>
        [JsonProperty("order_detail_link_page")]
        public string OrderDetailLinkPage { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态  PAID-已支付  MERCHANT_CONFIRMED-已确认  MERCHENT_SERVICING-服务中  MERCHANT_DELIVERD-已发货  MERCHANT_FINISHED-服务完成  REFUNDED-已退款
        /// </summary>
        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 买家实付金额
        /// </summary>
        [JsonProperty("real_pay_amount")]
        public string RealPayAmount { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [JsonProperty("tiny_app_id")]
        public string TinyAppId { get; set; }

        /// <summary>
        /// 小程序应用logo
        /// </summary>
        [JsonProperty("tiny_app_logo")]
        public string TinyAppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonProperty("tiny_app_name")]
        public string TinyAppName { get; set; }
    }
}
