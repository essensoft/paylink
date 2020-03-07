using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountFinriskMarkriskDatafactorQueryResponse.
    /// </summary>
    public class AlipayAccountFinriskMarkriskDatafactorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// json格式表示的计算结果，含多字段. 包括当前损益计算的货币对，预测金额，兑换渠道，交易日期，平盘价格，平盘金额，分级报价，汇率，汇率来源，汇率来源日期，场景，试算金额，交易主体，具体损益金额，交易类型，时区，产品码，补贴金额，已实现损益，未实现损益
        /// </summary>
        [JsonPropertyName("result_map")]
        public string ResultMap { get; set; }
    }
}
