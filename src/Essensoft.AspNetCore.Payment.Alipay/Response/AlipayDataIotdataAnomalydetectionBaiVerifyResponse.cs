using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataIotdataAnomalydetectionBaiVerifyResponse.
    /// </summary>
    public class AlipayDataIotdataAnomalydetectionBaiVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 结果为json字串，表示异常的详细信息，例如货物异常是新增和消失区域在图像上的坐标值
        /// </summary>
        [JsonPropertyName("event_detail")]
        public string EventDetail { get; set; }

        /// <summary>
        /// 算法检测到的异常类型，0表示无异常
        /// </summary>
        [JsonPropertyName("event_type")]
        public long EventType { get; set; }
    }
}
