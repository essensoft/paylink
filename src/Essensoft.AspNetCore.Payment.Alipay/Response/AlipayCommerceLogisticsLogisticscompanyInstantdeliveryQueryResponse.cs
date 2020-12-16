using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
