using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditProdarrangementContracttextQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditProdarrangementContracttextQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务编号，例如合约编号，贷款申请编号等
        /// </summary>
        [JsonProperty("bsn_no")]
        public string BsnNo { get; set; }

        /// <summary>
        /// 合同类型，枚举如下：LOAN：贷款合同类型，PRE_LOAN_INVESTIGATION : 贷前调查征信授权合同， POST_LOAN_MANAGEMENT : 贷后管理征信授权合同;
        /// </summary>
        [JsonProperty("contract_type")]
        public string ContractType { get; set; }

        /// <summary>
        /// 查询场景类型，例如根据业务单据号或者合约号来查询；  枚举如下：AR_NO：合约类型，BSN_NO：业务场景
        /// </summary>
        [JsonProperty("query_type")]
        public string QueryType { get; set; }
    }
}
