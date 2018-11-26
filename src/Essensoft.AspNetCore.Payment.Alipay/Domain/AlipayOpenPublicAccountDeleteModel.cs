using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAccountDeleteModel : AlipayObject
    {
        /// <summary>
        /// 协议号，商户会员在支付宝服务窗账号中的唯一标识，与bind_account_no不能同时为空
        /// </summary>
        [JsonProperty("agreement_id")]
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 绑定帐号，建议在开发者的系统中保持唯一性，与agreement_id不能同时为空
        /// </summary>
        [JsonProperty("bind_account_no")]
        [XmlElement("bind_account_no")]
        public string BindAccountNo { get; set; }
    }
}
