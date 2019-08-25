using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransGroupfundsBatchCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransGroupfundsBatchCreateModel : AlipayObject
    {
        /// <summary>
        /// 当前创建批次的支付宝用户ID
        /// </summary>
        [JsonProperty("current_user_id")]
        public string CurrentUserId { get; set; }

        /// <summary>
        /// 扩展参数，可选，业务扩展时使用
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 资金流入分配明细
        /// </summary>
        [JsonProperty("income_details")]
        public List<GroupFundsImcomeDetails> IncomeDetails { get; set; }

        /// <summary>
        /// 外部业务号，用作批次业务幂等，调用方保证相同的业务活动外部业务号相同，保证只能创建一次批次，业务规则业务自己定义
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务来源,对于聚会小程序统一透传"openParty"
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 资金转移总额,只支持两位小数点的正数,单位元
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
