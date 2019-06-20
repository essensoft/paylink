using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBankcardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrBankcardQueryModel : AlipayObject
    {
        /// <summary>
        /// 图片base64后内容，大小控制在1M以内
        /// </summary>
        [JsonProperty("image_content")]
        public string ImageContent { get; set; }
    }
}
