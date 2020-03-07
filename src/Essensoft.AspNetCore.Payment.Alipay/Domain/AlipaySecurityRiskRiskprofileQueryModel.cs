using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskRiskprofileQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskRiskprofileQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求来源，业务唯一标示；
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 风险对象枚举 可用值：userID,merchantID,tradeNO,phone,bankCard,IDCard,email;注意大小写敏感  枚举含义：userID：用户，merchantID：商户，tradeNO：交易号；phone：手机号，bankCard：银行卡，IDCard：身份证号，email：邮箱；
        /// </summary>
        [JsonPropertyName("risk_object")]
        public List<string> RiskObject { get; set; }

        /// <summary>
        /// 与字段risk_object 对应长度顺序一致，例如 ：risk_object值为["userID"] 则risk_object_value 值为["208830231508XXXX"];如 risk_object值为["userID",phone] 则risk_object_value 值为["208830231508XXXX","1856343XXXX"];
        /// </summary>
        [JsonPropertyName("risk_object_value")]
        public List<string> RiskObjectValue { get; set; }

        /// <summary>
        /// riskprofile 值接入时咨询业务PD 应该使用的riskprofile
        /// </summary>
        [JsonPropertyName("risk_profile")]
        public List<string> RiskProfile { get; set; }
    }
}
