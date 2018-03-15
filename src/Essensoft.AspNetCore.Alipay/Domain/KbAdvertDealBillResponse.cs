using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KbAdvertDealBillResponse Data Structure.
    /// </summary>
    public class KbAdvertDealBillResponse : AlipayObject
    {
        /// <summary>
        /// 账单下载地址(为空表示查无账单)
        /// </summary>
        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }
    }
}
