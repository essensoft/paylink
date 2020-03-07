using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountFinriskMarkriskDatafactorQueryModel Data Structure.
    /// </summary>
    public class AlipayAccountFinriskMarkriskDatafactorQueryModel : AlipayObject
    {
        /// <summary>
        /// Json格式表示市场风险损益计算入参
        /// </summary>
        [JsonPropertyName("data_factor_build_req")]
        public string DataFactorBuildReq { get; set; }
    }
}
