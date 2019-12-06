using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneDrawdownDetail Data Structure.
    /// </summary>
    public class SceneDrawdownDetail : AlipayObject
    {
        /// <summary>
        /// 网商支用号
        /// </summary>
        [JsonPropertyName("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 资方借据号
        /// </summary>
        [JsonPropertyName("fin_drawdown_no")]
        public string FinDrawdownNo { get; set; }
    }
}
