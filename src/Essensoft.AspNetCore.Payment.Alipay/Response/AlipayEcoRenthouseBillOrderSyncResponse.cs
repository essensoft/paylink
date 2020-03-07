using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderSyncResponse.
    /// </summary>
    public class AlipayEcoRenthouseBillOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// billNo-账单编号  status-1:成功
        /// </summary>
        [JsonPropertyName("result_bill_list")]
        public List<string> ResultBillList { get; set; }
    }
}
