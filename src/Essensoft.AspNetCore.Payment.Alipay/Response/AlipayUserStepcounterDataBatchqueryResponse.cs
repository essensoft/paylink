using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserStepcounterDataBatchqueryResponse.
    /// </summary>
    public class AlipayUserStepcounterDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的用户日计步信息
        /// </summary>
        [JsonPropertyName("step_info")]
        public List<StepcounterDataInfo> StepInfo { get; set; }
    }
}
