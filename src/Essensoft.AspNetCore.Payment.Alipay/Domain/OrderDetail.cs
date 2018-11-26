using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDetail : AlipayObject
    {
        /// <summary>
        /// 订单明细的应用唯一标识（16位纯数字），指商家的app_id。
        /// </summary>
        [JsonProperty("app_id")]
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 对交易或商品的描述
        /// </summary>
        [JsonProperty("body")]
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息.Json格式.  其它说明详见：“商品明细说明”
        /// </summary>
        [JsonProperty("goods_detail")]
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonProperty("out_trade_no")]
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则返回给商户时会回传该参数。支付宝只会在同步返回（包括跳转回商户网站）和异步通知时将该参数原样返回。本参数必须进行UrlEncode之后才可以发送给支付宝。
        /// </summary>
        [JsonProperty("passback_params")]
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 销售产品码，与支付宝签约的产品码名称
        /// </summary>
        [JsonProperty("product_code")]
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。  如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [JsonProperty("seller_id")]
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 支持手机和Email格式,如果同时使用参数seller_logon_id和seller_id,以seller_id为准
        /// </summary>
        [JsonProperty("seller_logon_id")]
        [XmlElement("seller_logon_id")]
        public string SellerLogonId { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [JsonProperty("show_url")]
        [XmlElement("show_url")]
        public string ShowUrl { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonProperty("subject")]
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
