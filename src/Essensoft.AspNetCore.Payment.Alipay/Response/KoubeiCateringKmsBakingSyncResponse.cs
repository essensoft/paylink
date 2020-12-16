using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringKmsBakingSyncResponse.
    /// </summary>
    public class KoubeiCateringKmsBakingSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 核对提示信息
        /// </summary>
        [JsonPropertyName("check_msg")]
        public string CheckMsg { get; set; }

        /// <summary>
        /// 核对专用字段，核对通过:true 核对未通过:false
        /// </summary>
        [JsonPropertyName("check_pass")]
        public bool CheckPass { get; set; }

        /// <summary>
        /// 平台统计已同步数据量
        /// </summary>
        [JsonPropertyName("sync_count")]
        public long SyncCount { get; set; }
    }
}
