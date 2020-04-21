using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 视觉货柜机型信息列表
        /// </summary>
        [JsonPropertyName("machine_types")]
        public List<MachineType> MachineTypes { get; set; }
    }
}
