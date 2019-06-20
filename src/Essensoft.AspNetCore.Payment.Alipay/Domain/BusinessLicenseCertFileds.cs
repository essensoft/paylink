using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessLicenseCertFileds Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessLicenseCertFileds : AlipayObject
    {
        /// <summary>
        /// 社会信用代码
        /// </summary>
        [JsonProperty("creditcode")]
        public string Creditcode { get; set; }

        /// <summary>
        /// 公司名字
        /// </summary>
        [JsonProperty("entname")]
        public string Entname { get; set; }
    }
}
