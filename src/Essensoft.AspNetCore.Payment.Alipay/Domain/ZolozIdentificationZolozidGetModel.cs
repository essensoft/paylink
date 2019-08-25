using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationZolozidGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationZolozidGetModel : AlipayObject
    {
        /// <summary>
        /// get region
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// bizId
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("extern_params")]
        public string ExternParams { get; set; }

        /// <summary>
        /// json字符串
        /// </summary>
        [JsonProperty("zcif_params")]
        public string ZcifParams { get; set; }
    }
}
