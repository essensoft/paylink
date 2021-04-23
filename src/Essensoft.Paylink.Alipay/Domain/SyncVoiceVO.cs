using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SyncVoiceVO Data Structure.
    /// </summary>
    public class SyncVoiceVO : AlipayObject
    {
        /// <summary>
        /// 播报的金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 合并播报开关，默认为0。设置为1后用于短时间内同时发生多笔播报时，优化播报提示内容。如支付宝到账1元、2元、3元
        /// </summary>
        [JsonPropertyName("merge_switch")]
        public long MergeSwitch { get; set; }

        /// <summary>
        /// 金额播报开关。置为0则只会播报到账提示音，不会播报具体金额。
        /// </summary>
        [JsonPropertyName("money_switch")]
        public long MoneySwitch { get; set; }

        /// <summary>
        /// 支付的渠道类型
        /// </summary>
        [JsonPropertyName("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 交易id
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }
    }
}
