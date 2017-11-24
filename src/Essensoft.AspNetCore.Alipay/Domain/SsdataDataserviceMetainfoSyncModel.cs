using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceMetainfoSyncModel Data Structure.
    /// </summary>
    public class SsdataDataserviceMetainfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 元数据信息
        /// </summary>
        [JsonProperty("meta_info")]
        public string MetaInfo { get; set; }
    }
}
