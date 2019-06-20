using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsScenePolicyEndorseApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePolicyEndorseApplyModel : AlipayObject
    {
        /// <summary>
        /// 批单项列表
        /// </summary>
        [JsonProperty("endorse_items")]
        public List<InsEndorseItem> EndorseItems { get; set; }

        /// <summary>
        /// 商户生成的批改请求单号【幂等字段】
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 保单凭证号;蚂蚁保险平台生成的保单凭证号,用户可以通过此单号去保险公司查询保单信息.
        /// </summary>
        [JsonProperty("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 批单来源
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
