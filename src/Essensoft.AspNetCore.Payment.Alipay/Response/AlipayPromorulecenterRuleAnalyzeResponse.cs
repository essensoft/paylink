using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPromorulecenterRuleAnalyzeResponse.
    /// </summary>
    public class AlipayPromorulecenterRuleAnalyzeResponse : AlipayResponse
    {
        /// <summary>
        /// 未通过条件描述信息
        /// </summary>
        [JsonProperty("fail_condition_msg")]
        [XmlElement("fail_condition_msg")]
        public string FailConditionMsg { get; set; }

        /// <summary>
        /// 未通过的条件
        /// </summary>
        [JsonProperty("fail_condition_name")]
        [XmlElement("fail_condition_name")]
        public string FailConditionName { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("result_code")]
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 服务调用是否成功
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public string Success { get; set; }

        /// <summary>
        /// 规则是否通过
        /// </summary>
        [JsonProperty("triggered")]
        [XmlElement("triggered")]
        public string Triggered { get; set; }
    }
}
