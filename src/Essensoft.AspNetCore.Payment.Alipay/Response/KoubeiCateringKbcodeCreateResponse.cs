using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringKbcodeCreateResponse.
    /// </summary>
    public class KoubeiCateringKbcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑码创建的批次号，可以根据该批次号查询创建的具体码信息
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }
    }
}
