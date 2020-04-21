using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataBaiCargocountQueryModel Data Structure.
    /// </summary>
    public class AlipayDataIotdataBaiCargocountQueryModel : AlipayObject
    {
        /// <summary>
        /// 货物盘点使用的摄像头id
        /// </summary>
        [JsonPropertyName("camera_id")]
        public long CameraId { get; set; }

        /// <summary>
        /// JSON字符串，包含盘点算法使用的超参数如畸变矫正矩阵，透视变换矩阵，库位RoI区域等
        /// </summary>
        [JsonPropertyName("counting_params")]
        public string CountingParams { get; set; }

        /// <summary>
        /// 用于盘点的视频帧产生时间，Unix时间戳，单位秒
        /// </summary>
        [JsonPropertyName("counting_time")]
        public long CountingTime { get; set; }

        /// <summary>
        /// base64编码视频帧数据
        /// </summary>
        [JsonPropertyName("input_frame")]
        public string InputFrame { get; set; }

        /// <summary>
        /// 算法用于盘点指定货物的模板图像数据，base64编码
        /// </summary>
        [JsonPropertyName("input_template")]
        public string InputTemplate { get; set; }
    }
}
