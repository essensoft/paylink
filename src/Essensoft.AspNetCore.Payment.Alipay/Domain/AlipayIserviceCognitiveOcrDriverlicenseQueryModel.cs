using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrDriverlicenseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrDriverlicenseQueryModel : AlipayObject
    {
        /// <summary>
        /// 驾驶证图片base64加密后内容，大小控制在1.5M以内
        /// </summary>
        [JsonProperty("image_content")]
        public string ImageContent { get; set; }
    }
}
