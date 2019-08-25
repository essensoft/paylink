using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceMetainfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceMetainfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 元数据信息
        /// </summary>
        [JsonProperty("meta_info")]
        public string MetaInfo { get; set; }
    }
}
