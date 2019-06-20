using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskDigitalidentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskDigitalidentityQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务端生成的设备码（由我方提供的sdk生成）
        /// </summary>
        [JsonProperty("device_code")]
        public string DeviceCode { get; set; }
    }
}
