using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsLogisticscompanyInstantdeliveryQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsLogisticscompanyInstantdeliveryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 即时配送公司列表
        /// </summary>
        [JsonPropertyName("logistics_companies")]
        public List<LogisticsCompanyResult> LogisticsCompanies { get; set; }
    }
}
