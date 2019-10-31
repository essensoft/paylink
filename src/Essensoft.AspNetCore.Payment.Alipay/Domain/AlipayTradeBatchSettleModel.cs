using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeBatchSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeBatchSettleModel : AlipayObject
    {
        /// <summary>
        /// 收单产品码，商家和支付宝签约的产品码
        /// </summary>
        [JsonProperty("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 结算请求外部流水号，32个字符以内、可包含字母、数字、下划线；需保证在商户端不重复，如果重复则返回该流水号对应的结算单据的状态。
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 结算明细条款
        /// </summary>
        [JsonProperty("settle_clauses")]
        public List<SettleClause> SettleClauses { get; set; }
    }
}
