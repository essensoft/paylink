using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DeviceTradeDetail Data Structure.
    /// </summary>
    public class DeviceTradeDetail : AlipayObject
    {
        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 统计时间
        /// </summary>
        [JsonPropertyName("max_dt")]
        public string MaxDt { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [JsonPropertyName("pay_mode")]
        public string PayMode { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("trade_amt")]
        public string TradeAmt { get; set; }

        /// <summary>
        /// 设备交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonPropertyName("trade_time")]
        public string TradeTime { get; set; }
    }
}
