using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodVidGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodVidGetModel : AlipayObject
    {
        /// <summary>
        /// 支付宝版本号
        /// </summary>
        [JsonProperty("alipay_version")]
        [XmlElement("alipay_version")]
        public string AlipayVersion { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [JsonProperty("org_code")]
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [JsonProperty("site")]
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("site_user_id")]
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
