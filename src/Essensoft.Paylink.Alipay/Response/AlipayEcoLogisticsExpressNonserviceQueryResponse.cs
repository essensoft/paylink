using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoLogisticsExpressNonserviceQueryResponse.
    /// </summary>
    public class AlipayEcoLogisticsExpressNonserviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 非服务区区域代码列表
        /// </summary>
        [JsonPropertyName("area_codes")]
        public List<AreaCode> AreaCodes { get; set; }
    }
}
