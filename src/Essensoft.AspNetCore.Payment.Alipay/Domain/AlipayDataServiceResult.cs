using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataServiceResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataServiceResult : AlipayObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 调用结果，json格式
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
