using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodPaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodPaymentQueryModel : AlipayObject
    {
        /// <summary>
        /// 网商内部代收付申请单编号，外部机构根据此编号查询申请状态。
        /// </summary>
        [JsonProperty("in_apply_no")]
        [XmlElement("in_apply_no")]
        public string InApplyNo { get; set; }
    }
}
