using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceAudioSyncModel : AlipayObject
    {
        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 交易流水号. 在以下情况下必填: 1. 如果需要调用alipay.commerce.iot.device.broadcast.query接口,查询设备是否播报,则trade_id必填; 2. 如果是交易播报则交易流水号必填,也就是说voice_content里面包含money参数的,则trade_id必填
        /// </summary>
        [JsonProperty("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 仅在使用内置到账语音进行播报的时候需要传入. 表示交易类型. 可选值:   ALIPAY_TRADE 支付宝交易  WX_TRADE 微信交易  OTHER 其他交易途径
        /// </summary>
        [JsonProperty("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 播报内容，由str，money和audio组成. 如：  audio:S4668BUGQbSOwwmg2GjmbQAAACMAAQED => 欢迎光临  audio:Qf-1zBDbTB-mq2U4FzoGiwAAACMAAQED|money:32.5 => 企迈收款32.5元  audio:zKcE111AByT2fz8pLL1zMBE1C234AfmX|str:T001|audio:AQ1e213e1nYYII1MMN2dfPO3466AAAB2 => 扫呗T001桌扫码点餐，请及时处理  money:32.5 => 根据trade_type,使用对应的内置语音播报交易到账
        /// </summary>
        [JsonProperty("voice_content")]
        public string VoiceContent { get; set; }
    }
}
