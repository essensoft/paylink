using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 统一收单交易关闭异步通知
    /// 更新时间：2020-03-03
    /// https://opendocs.alipay.com/apis/api_1/alipay.trade.close
    /// </summary>
    public class AlipayTradeCloseNotify : AlipayNotify
    {
        /// <summary>
        /// 通知时间
        /// </summary>
        [JsonPropertyName("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [JsonPropertyName("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 通知校验ID
        /// </summary>
        [JsonPropertyName("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 支付宝分配给开发者的应用Id
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 授权方应用id
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 编码格式
        /// </summary>
        [JsonPropertyName("charset")]
        public string Charset { get; set; }

        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonPropertyName("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 买家支付宝用户号
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [JsonPropertyName("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 卖家支付宝用户号
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家支付宝账号
        /// </summary>
        [JsonPropertyName("seller_email")]
        public string SellerEmail { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonPropertyName("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }
    }
}
