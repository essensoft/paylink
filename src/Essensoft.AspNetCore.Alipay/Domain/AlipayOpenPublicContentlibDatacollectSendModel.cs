using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicContentlibDatacollectSendModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicContentlibDatacollectSendModel : AlipayObject
    {
        /// <summary>
        /// 爬虫平台推送数据，为json字符串，bizNo 为推送流水号，taskName为任务名，业务数据包含在bizData中
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
