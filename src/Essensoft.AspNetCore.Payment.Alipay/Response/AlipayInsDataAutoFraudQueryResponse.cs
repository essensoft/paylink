using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsDataAutoFraudQueryResponse.
    /// </summary>
    public class AlipayInsDataAutoFraudQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 案件欺诈名单类型：    BLACK:黑名单。高风险，需重点调查  GRAY:灰名单。较高风险  WHITE:白名单。风险较低
        /// </summary>
        [JsonPropertyName("fraud_tag")]
        public string FraudTag { get; set; }

        /// <summary>
        /// 反欺诈名单标识下的档位，从字母A开始编号，A为最高风险。目前每种名单下为六档，白名单下没有档位
        /// </summary>
        [JsonPropertyName("fraud_tag_level")]
        public string FraudTagLevel { get; set; }

        /// <summary>
        /// 情报代码列表，可选输出项
        /// </summary>
        [JsonPropertyName("info_code_list")]
        public List<CaseInfoCode> InfoCodeList { get; set; }
    }
}
