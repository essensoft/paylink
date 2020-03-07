using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodRepayDeputyApplyResponse.
    /// </summary>
    public class MybankCreditSceneprodRepayDeputyApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 网商分配的申请单号
        /// </summary>
        [JsonPropertyName("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 代客还款账单详情
        /// </summary>
        [JsonPropertyName("bill_list")]
        public List<SceneProdDeputyPaymentBillQuery> BillList { get; set; }

        /// <summary>
        /// 网商分配的支用号
        /// </summary>
        [JsonPropertyName("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
