using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPartnerMenuOperateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPartnerMenuOperateModel : AlipayObject
    {
        /// <summary>
        /// 行为参数
        /// </summary>
        [JsonProperty("action_param")]
        [XmlElement("action_param")]
        public string ActionParam { get; set; }

        /// <summary>
        /// 行为类型(in，out，api)
        /// </summary>
        [JsonProperty("action_type")]
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        [JsonProperty("agreement_id")]
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 服务窗id
        /// </summary>
        [JsonProperty("public_id")]
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 第三方账号ID ,银行卡号/户号/手机号
        /// </summary>
        [JsonProperty("third_account_id")]
        [XmlElement("third_account_id")]
        public string ThirdAccountId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
