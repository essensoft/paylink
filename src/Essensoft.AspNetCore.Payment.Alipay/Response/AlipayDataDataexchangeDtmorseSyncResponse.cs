using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataexchangeDtmorseSyncResponse.
    /// </summary>
    public class AlipayDataDataexchangeDtmorseSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 结果扩展字段，用于补充出参内容
        /// </summary>
        [JsonPropertyName("result_extent")]
        public string ResultExtent { get; set; }

        /// <summary>
        /// 操作结果信息，用于标识操作是否成功。true：表示成功，false：表示失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
