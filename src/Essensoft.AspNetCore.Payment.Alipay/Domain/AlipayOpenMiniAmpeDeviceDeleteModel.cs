using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeDeviceDeleteModel : AlipayObject
    {
        /// <summary>
        /// 厂商在对应设备产品和机型下已添加的设备ID，单次最多提交200个
        /// </summary>
        [JsonPropertyName("device_id_list")]
        public List<string> DeviceIdList { get; set; }

        /// <summary>
        /// 设备产品下具体的一个机型ID，由系统生成
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 设备产品的productId，由系统生成
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
