using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneServiceOrderQueryResponse.
    /// </summary>
    public class AlipayInsSceneServiceOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [JsonPropertyName("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 服务止期
        /// </summary>
        [JsonPropertyName("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 服务起期
        /// </summary>
        [JsonPropertyName("effect_start_time")]
        public string EffectStartTime { get; set; }
    }
}
