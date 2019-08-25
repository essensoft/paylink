using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveInvoicesInferenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveInvoicesInferenceQueryModel : AlipayObject
    {
        /// <summary>
        /// 图片base64加密后的内容
        /// </summary>
        [JsonProperty("img_content")]
        public string ImgContent { get; set; }
    }
}
