using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AmpeDeviceVO Data Structure.
    /// </summary>
    public class AmpeDeviceVO : AlipayObject
    {
        /// <summary>
        /// 数据插入时间
        /// </summary>
        [JsonPropertyName("add_time")]
        public string AddTime { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备机型id
        /// </summary>
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 设备机型名称
        /// </summary>
        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 设备机型编号
        /// </summary>
        [JsonPropertyName("model_no")]
        public string ModelNo { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }
    }
}
