using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 手机网站支付页面回跳参数
    /// 更新时间：2019-11-08
    /// https://docs.open.alipay.com/203/107090/
    /// </summary>
    public class AlipayTradeWapPayReturn : AlipayNotify
    {
        // 公共参数

        /// <summary>
        /// 开发者的app_id
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 接口
        /// </summary>
        [JsonPropertyName("method")]
        public string Method { get; set; }

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
        /// 编码格式
        /// </summary>
        [JsonPropertyName("charset")]
        public string Charset { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        // 业务参数

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 卖家支付宝用户号
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }
    }
}
