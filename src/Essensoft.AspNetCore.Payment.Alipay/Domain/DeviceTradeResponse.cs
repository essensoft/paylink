using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceTradeResponse Data Structure.
    /// </summary>
    public class DeviceTradeResponse : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设备sn，通常置于设备标签中
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 交易错误提示  例如：未收录设备的SDK交易
        /// </summary>
        [JsonPropertyName("iot_trade_error_type")]
        public string IotTradeErrorType { get; set; }

        /// <summary>
        /// 物料id,由支付宝同学提供
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// SDK加签名信息
        /// </summary>
        [JsonPropertyName("terminal_sdk_sign_info")]
        public string TerminalSdkSignInfo { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [JsonPropertyName("trade_finish_time")]
        public string TradeFinishTime { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
