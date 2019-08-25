using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderCreditCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderCreditCreateModel : AlipayObject
    {
        /// <summary>
        /// 该笔订单的资金总金额，取值范围[0.01,100000000]，精确到小数点后2位。
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 芝麻业务端分配的风险类目
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 业务办理渠道，商户自定义
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 该笔订单的押金总额，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonProperty("deposit")]
        public string Deposit { get; set; }

        /// <summary>
        /// 此处固定填写WEB，如果是小程序渠道，则填写TINY_APP
        /// </summary>
        [JsonProperty("from_channel")]
        public string FromChannel { get; set; }

        /// <summary>
        /// 芝麻业务端分配的业务识别码，商户入驻签约后分配
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 订单处理url，商户处理订单的页面，例如订单详情url，目前仅用于线下租赁(景区)业务
        /// </summary>
        [JsonProperty("order_process_url")]
        public string OrderProcessUrl { get; set; }

        /// <summary>
        /// 商户的订单号或业务办理号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 业务逾期时间，请根据实际业务合理设置该值，如果是线上或线下租赁业务则该字段不允许为空，格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("overdue_time")]
        public string OverdueTime { get; set; }

        /// <summary>
        /// 商品内容，JSON格式，该部分信息会在信用收单页展示给用户，注意：如果数据包含中文，需要对该数据先进行一次编码，如示例值里的"bicycle"想传入"汉服"，则需要进行编码
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}
