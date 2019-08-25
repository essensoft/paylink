using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneDrawdownDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SceneDrawdownDetail : AlipayObject
    {
        /// <summary>
        /// 网商支用号
        /// </summary>
        [JsonProperty("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 资方借据号
        /// </summary>
        [JsonProperty("fin_drawdown_no")]
        public string FinDrawdownNo { get; set; }
    }
}
