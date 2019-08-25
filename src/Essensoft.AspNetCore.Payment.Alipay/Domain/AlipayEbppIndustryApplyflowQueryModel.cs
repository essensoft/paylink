using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryApplyflowQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryApplyflowQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝办理流水号，支持幂等，和外部办理流水号之间必须传一个
        /// </summary>
        [JsonProperty("apply_flow_no")]
        public string ApplyFlowNo { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 外部申请流水号，支持幂等，和支付宝办理流水号之间必须传一个
        /// </summary>
        [JsonProperty("out_apply_no")]
        public string OutApplyNo { get; set; }
    }
}
