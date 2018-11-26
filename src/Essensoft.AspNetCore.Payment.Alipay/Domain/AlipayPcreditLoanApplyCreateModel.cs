using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanApplyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanApplyCreateModel : AlipayObject
    {
        /// <summary>
        /// 申贷金额，单位为元
        /// </summary>
        [JsonProperty("apply_amt")]
        [XmlElement("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 用户身份证后4位
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户贴息率，0~1的小数
        /// </summary>
        [JsonProperty("ratio")]
        [XmlElement("ratio")]
        public long Ratio { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("scene")]
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
