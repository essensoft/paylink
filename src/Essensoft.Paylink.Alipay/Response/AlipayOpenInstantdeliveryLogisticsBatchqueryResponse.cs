using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryLogisticsBatchqueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryLogisticsBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支持的即时配送公司列表
        /// </summary>
        [JsonPropertyName("logistics_companys")]
        public List<LogisticsCompanyDTO> LogisticsCompanys { get; set; }
    }
}
