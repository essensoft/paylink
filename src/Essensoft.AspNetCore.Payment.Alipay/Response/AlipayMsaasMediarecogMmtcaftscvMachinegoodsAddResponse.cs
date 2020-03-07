using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddResponse : AlipayResponse
    {
        /// <summary>
        /// 柜内区域状态
        /// </summary>
        [JsonPropertyName("regions")]
        public List<RegionState> Regions { get; set; }
    }
}
