using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommerceAppUploadResponseData Data Structure.
    /// </summary>
    [Serializable]
    public class CommerceAppUploadResponseData : AlipayObject
    {
        /// <summary>
        /// 返回主体中具体内容
        /// </summary>
        [JsonProperty("response")]
        public string Response { get; set; }

        /// <summary>
        /// 系统时间
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
