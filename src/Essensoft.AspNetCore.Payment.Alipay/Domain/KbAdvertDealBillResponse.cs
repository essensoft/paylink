using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertDealBillResponse Data Structure.
    /// </summary>
    public class KbAdvertDealBillResponse : AlipayObject
    {
        /// <summary>
        /// 账单下载地址(为空表示查无账单)
        /// </summary>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }
    }
}
