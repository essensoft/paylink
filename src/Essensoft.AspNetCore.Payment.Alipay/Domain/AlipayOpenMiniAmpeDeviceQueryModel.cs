using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeDeviceQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备id，选填
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 机型ID，必填
        /// </summary>
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 当前页，选填，默认值为1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数，选填，默认值10, 最大值为100
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 产品ID，必填
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
