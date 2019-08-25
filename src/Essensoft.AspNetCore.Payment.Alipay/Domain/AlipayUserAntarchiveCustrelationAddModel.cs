using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveCustrelationAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntarchiveCustrelationAddModel : AlipayObject
    {
        /// <summary>
        /// 待关联客户id
        /// </summary>
        [JsonProperty("cust_id")]
        public string CustId { get; set; }

        /// <summary>
        /// 蚂蚁档案身份信息证明
        /// </summary>
        [JsonProperty("identity_certificate")]
        public AntArchiveIdentityCertificate IdentityCertificate { get; set; }
    }
}
