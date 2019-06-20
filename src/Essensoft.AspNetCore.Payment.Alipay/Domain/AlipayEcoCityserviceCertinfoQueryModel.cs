using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceCertinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceCertinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户证件信息列表。
        /// </summary>
        [JsonProperty("cert_infos")]
        public List<CertInfoRequest> CertInfos { get; set; }
    }
}
