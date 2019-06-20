using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderResultSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDeployorderResultSendModel : AlipayObject
    {
        /// <summary>
        /// 部署单记录id
        /// </summary>
        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
