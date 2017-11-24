using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ServiceOrderInfo Data Structure.
    /// </summary>
    public class ServiceOrderInfo : AlipayObject
    {
        /// <summary>
        /// 服务总金额，单位为元
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品服务所在类目的id
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 订单创建时间，格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间，格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 订单最后支付时间，格式：  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 订单最后退款时间，格式：  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 消费者标注订单备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 第三方服务id
        /// </summary>
        [JsonProperty("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 商品的商家端端SKU ID
        /// </summary>
        [JsonProperty("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 第三方服务者id列表，例子：  [“2323”,…]，如果没有服务者，则为[]
        /// </summary>
        [JsonProperty("out_sp_id")]
        public List<string> OutSpId { get; set; }

        /// <summary>
        /// 服务已付金额，单位为元
        /// </summary>
        [JsonProperty("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 单价，单位为元
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 份数
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 服务实际金额，单位为元
        /// </summary>
        [JsonProperty("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 订单退款金额，单位为元
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 到位的服务id
        /// </summary>
        [JsonProperty("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务订单号
        /// </summary>
        [JsonProperty("service_order_no")]
        public string ServiceOrderNo { get; set; }

        /// <summary>
        /// 商品的内部SKU ID
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 商品价格单位
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
