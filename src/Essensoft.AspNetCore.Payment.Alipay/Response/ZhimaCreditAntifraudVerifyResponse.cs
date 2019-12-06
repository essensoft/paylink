using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditAntifraudVerifyResponse.
    /// </summary>
    public class ZhimaCreditAntifraudVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 决策结果，可空，取值当前为REJECT\REVIEW\PASS，产品定制使用。根据产品定制配置，对结果进行决策返回
        /// </summary>
        [JsonPropertyName("decision_result")]
        public string DecisionResult { get; set; }

        /// <summary>
        /// 方案ID，可空，产品定制使用。在线可能会存在多个方案并行，方案ID标识当前请求使用的在线方案
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// <a href="https://doc.open.alipay.com/docs/doc.htm?treeId=272&articleId=105917&docType=1">验证code列表</a>
        /// </summary>
        [JsonPropertyName("verify_code")]
        public List<string> VerifyCode { get; set; }
    }
}
