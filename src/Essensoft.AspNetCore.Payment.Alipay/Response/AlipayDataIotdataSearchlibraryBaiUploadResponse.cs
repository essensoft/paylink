using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataIotdataSearchlibraryBaiUploadResponse.
    /// </summary>
    public class AlipayDataIotdataSearchlibraryBaiUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 更新失败原因
        /// </summary>
        [JsonPropertyName("update_desc")]
        public string UpdateDesc { get; set; }

        /// <summary>
        /// 更新是否成功
        /// </summary>
        [JsonPropertyName("update_result")]
        public bool UpdateResult { get; set; }
    }
}
