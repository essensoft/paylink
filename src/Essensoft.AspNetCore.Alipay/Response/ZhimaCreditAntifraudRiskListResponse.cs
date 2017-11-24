using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditAntifraudRiskListResponse.
    /// </summary>
    public class ZhimaCreditAntifraudRiskListResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 是否命中风险编码，yes标识命中，no标识未命中
        /// </summary>
        [JsonProperty("hit_risk")]
        public string HitRisk { get; set; }

        /// <summary>
        /// 命中风险项的RiskCode列表，对应的描述见产品文档
        /// </summary>
        [JsonProperty("risk_code")]
        public List<string> RiskCode { get; set; }
    }
}
