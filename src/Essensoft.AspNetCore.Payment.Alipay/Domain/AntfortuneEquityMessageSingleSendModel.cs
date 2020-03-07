using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneEquityMessageSingleSendModel Data Structure.
    /// </summary>
    public class AntfortuneEquityMessageSingleSendModel : AlipayObject
    {
        /// <summary>
        /// TA编码
        /// </summary>
        [JsonPropertyName("ta_code")]
        public string TaCode { get; set; }

        /// <summary>
        /// 消息模板相关参数，其中包括templateId模板ID和context模板上下文
        /// </summary>
        [JsonPropertyName("template")]
        public MessageTemplate Template { get; set; }

        /// <summary>
        /// 基金交易账号
        /// </summary>
        [JsonPropertyName("trade_account")]
        public string TradeAccount { get; set; }
    }
}
