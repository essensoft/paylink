using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDevicelogUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodDevicelogUploadModel : AlipayObject
    {
        /// <summary>
        /// 行为日志主体
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 日志模板名称
        /// </summary>
        [JsonProperty("template_name")]
        public string TemplateName { get; set; }
    }
}
