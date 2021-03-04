using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppConfigChargeinstSearchResponse.
    /// </summary>
    public class AlipayEbppConfigChargeinstSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 接口输出参数列表 ChargeInstResult{ List<ChargeInstMode>}对象
        /// </summary>
        [JsonPropertyName("charge_inst_mode_result")]
        public List<ChargeInstMode> ChargeInstModeResult { get; set; }
    }
}
