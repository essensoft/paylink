using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceBroadcastQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceBroadcastQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 交易流水号, 此参数即为语音播报接口alipay.commerce.iot.device.audio.sync传入的trade_id
        /// </summary>
        [JsonProperty("trade_id")]
        public string TradeId { get; set; }
    }
}
