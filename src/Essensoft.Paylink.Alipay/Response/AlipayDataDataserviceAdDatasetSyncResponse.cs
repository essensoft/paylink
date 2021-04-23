using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdDatasetSyncResponse.
    /// </summary>
    public class AlipayDataDataserviceAdDatasetSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 成功同步数据集外部标志
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }
    }
}
