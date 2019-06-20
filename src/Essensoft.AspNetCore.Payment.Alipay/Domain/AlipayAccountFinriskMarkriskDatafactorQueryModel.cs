using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountFinriskMarkriskDatafactorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountFinriskMarkriskDatafactorQueryModel : AlipayObject
    {
        /// <summary>
        /// Json格式表示市场风险损益计算入参
        /// </summary>
        [JsonProperty("data_factor_build_req")]
        public string DataFactorBuildReq { get; set; }
    }
}
