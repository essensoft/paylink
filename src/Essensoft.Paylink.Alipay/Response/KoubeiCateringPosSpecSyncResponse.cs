using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosSpecSyncResponse.
    /// </summary>
    public class KoubeiCateringPosSpecSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
