using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceDataBatchqueryResponse.
    /// </summary>
    public class AlipayCreditAutofinanceDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单数据查询的返回值。通过列表方式批量返回机构的订单查询数据。通过系统控制返回的数据中不包含客户的敏感信息。
        /// </summary>
        [JsonPropertyName("result_data")]
        public List<SceneDataQueryResultDetail> ResultData { get; set; }
    }
}
