using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceAddModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeDeviceAddModel : AlipayObject
    {
        /// <summary>
        /// 用于标识厂商单个设备产品下唯一的一个设备，推荐使用厂商自己定义的序列号。单次最多提交200个，如果productId下已存在deviceId，会被更新为最新一次提交的数据
        /// </summary>
        [JsonPropertyName("device_id_list")]
        public List<string> DeviceIdList { get; set; }

        /// <summary>
        /// 设备产品下具体的一个机型ID，由系统生成
        /// </summary>
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 设备产品的productId，由系统生成
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
