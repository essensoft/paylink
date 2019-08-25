using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimReportModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimReportModifyModel : AlipayObject
    {
        /// <summary>
        /// 出险地点
        /// </summary>
        [JsonProperty("accident_address")]
        public string AccidentAddress { get; set; }

        /// <summary>
        /// 出险描述
        /// </summary>
        [JsonProperty("accident_desc")]
        public string AccidentDesc { get; set; }

        /// <summary>
        /// 出险时间
        /// </summary>
        [JsonProperty("accident_time")]
        public string AccidentTime { get; set; }

        /// <summary>
        /// 理赔报案的属性字段，标准JSON格式
        /// </summary>
        [JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 申请理赔的报案号
        /// </summary>
        [JsonProperty("claim_report_no")]
        public string ClaimReportNo { get; set; }
    }
}
