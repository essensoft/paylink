using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataIotdataBaiCargocountQueryResponse.
    /// </summary>
    public class AlipayDataIotdataBaiCargocountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// JSON字符串，包含盘点结果详情，如检测到每个货物的中心点坐标
        /// </summary>
        [JsonPropertyName("storage_detail")]
        public string StorageDetail { get; set; }

        /// <summary>
        /// 算法盘点出的货物数量
        /// </summary>
        [JsonPropertyName("storage_num")]
        public long StorageNum { get; set; }
    }
}
