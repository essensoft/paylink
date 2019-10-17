using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 电脑网站支付页面回跳参数
    /// 更新时间：2019-10-10
    /// https://docs.open.alipay.com/203/107090/
    /// 暂缺根据官方文档(https://opensupport.alipay.com/support/knowledge/20070/201602425007?ant_source=zsearch)
    /// 参考：手机网站支付同步通知参数说明
    /// </summary>
    public class AlipayTradePagePayReturn : AlipayNotify
    {
        // 公共参数

        /// <summary>
        /// 开发者的app_id
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 接口
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 编码格式
        /// </summary>
        [JsonProperty("charset")]
        public string Charset { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        // 业务参数

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 卖家支付宝用户号
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }
    }
}
