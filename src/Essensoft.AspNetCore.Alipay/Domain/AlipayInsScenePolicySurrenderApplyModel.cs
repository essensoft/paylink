using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayInsScenePolicySurrenderApplyModel Data Structure.
    /// </summary>
    public class AlipayInsScenePolicySurrenderApplyModel : AlipayObject
    {
        /// <summary>
        /// 退保扩展参数 ;标准json格式
        /// </summary>
        [JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 蚂蚁保险平台生成的保单号
        /// </summary>
        [JsonProperty("policy_no")]
        public string PolicyNo { get; set; }
    }
}
