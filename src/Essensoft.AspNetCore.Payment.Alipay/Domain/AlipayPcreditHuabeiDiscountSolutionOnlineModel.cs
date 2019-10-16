using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiDiscountSolutionOnlineModel : AlipayObject
    {
        /// <summary>
        /// solution_id，贴息方案实例id
        /// </summary>
        [JsonProperty("solution_id")]
        public string SolutionId { get; set; }
    }
}
