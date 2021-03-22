using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppEdeductForecastQueryResponse.
    /// </summary>
    public class AlipayEbppEdeductForecastQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否符合预期，true则说明符合预测，false则说明不符合预测，需要进行拦截。
        /// </summary>
        [JsonPropertyName("forecast_expect")]
        public bool ForecastExpect { get; set; }
    }
}
