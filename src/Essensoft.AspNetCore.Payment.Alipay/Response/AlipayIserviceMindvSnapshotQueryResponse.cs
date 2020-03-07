using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceMindvSnapshotQueryResponse.
    /// </summary>
    public class AlipayIserviceMindvSnapshotQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 快照创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 快照唯一id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
