using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EntertainmentOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EntertainmentOrderInfo : AlipayObject
    {
        /// <summary>
        /// 订单号,通过回调获得  如果订单状态为2  未支付  那就不存在alipay_trade_no 就不是必填  3和5 用户付款行为已经发生，那么 alipay_trade_no  就是必填
        /// </summary>
        [JsonProperty("alipay_trade_no")]
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [JsonProperty("alipay_uid")]
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 订单完成时间(UNIX时间戳)  未支付自动关闭
        /// </summary>
        [JsonProperty("complete_time")]
        [XmlElement("complete_time")]
        public long CompleteTime { get; set; }

        /// <summary>
        /// 下单时间(UNIX时间戳)
        /// </summary>
        [JsonProperty("create_time")]
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 额外的参数信息,格式为json
        /// </summary>
        [JsonProperty("ext_param")]
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 与娱乐充值平台对接的商品编码
        /// </summary>
        [JsonProperty("goods_code")]
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 与娱乐充值平台对接的商品名称
        /// </summary>
        [JsonProperty("goods_name")]
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 标识是哪个isv来源的订单
        /// </summary>
        [JsonProperty("isv_code")]
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// isv订单号(每个isv独立保证唯一,16位)
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 2-未支付自动关闭  3-退款  5-交易完成
        /// </summary>
        [JsonProperty("order_status")]
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 支付时间(UNIX时间戳)
        /// </summary>
        [JsonProperty("pay_time")]
        [XmlElement("pay_time")]
        public long PayTime { get; set; }

        /// <summary>
        /// 与娱乐充值平台对接的产品编号
        /// </summary>
        [JsonProperty("product_code")]
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 与娱乐充值平台对接的产品名称
        /// </summary>
        [JsonProperty("product_name")]
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 用户购买数量
        /// </summary>
        [JsonProperty("quantity")]
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 用户总支付金额
        /// </summary>
        [JsonProperty("total_payment")]
        [XmlElement("total_payment")]
        public string TotalPayment { get; set; }

        /// <summary>
        /// 每个商品单价
        /// </summary>
        [JsonProperty("unit_price")]
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 用户充值账号
        /// </summary>
        [JsonProperty("user_account")]
        [XmlElement("user_account")]
        public string UserAccount { get; set; }
    }
}
