using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicemodelModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicemodelModifyModel : AlipayObject
    {
        /// <summary>
        /// 硬件参数，选填，三选一，最大长度30
        /// </summary>
        [JsonPropertyName("hardware_params")]
        public string HardwareParams { get; set; }

        /// <summary>
        /// 机型ID，必填
        /// </summary>
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 机型名称，选填，三选一，最大长度30，单productId下唯一
        /// </summary>
        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 机型编号，选填，三选一，最大长度30，单productId下唯一
        /// </summary>
        [JsonPropertyName("model_no")]
        public string ModelNo { get; set; }

        /// <summary>
        /// 产品ID，必填
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
