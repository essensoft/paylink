using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailKbcodeCreateResponse.
    /// </summary>
    public class KoubeiRetailKbcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑码生成批次id，可用于查询接口
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }
    }
}
