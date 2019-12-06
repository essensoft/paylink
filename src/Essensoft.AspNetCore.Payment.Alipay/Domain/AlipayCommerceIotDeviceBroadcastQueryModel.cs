using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceBroadcastQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceBroadcastQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 交易流水号, 此参数即为语音播报接口alipay.commerce.iot.device.audio.sync传入的trade_id
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }
    }
}
