using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyIdentifyFileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyIdentifyFileQueryModel : AlipayObject
    {
        /// <summary>
        /// 文件的地址
        /// </summary>
        [JsonProperty("file_url")]
        public string FileUrl { get; set; }
    }
}
