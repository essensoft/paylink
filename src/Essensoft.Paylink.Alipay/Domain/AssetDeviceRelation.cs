using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AssetDeviceRelation Data Structure.
    /// </summary>
    public class AssetDeviceRelation : AlipayObject
    {
        /// <summary>
        /// asset_id 金融资产ID， 字段不唯一。 提交金融资产时，由资管平台返回。
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// device_ids，字段不唯一，和用户提交金融资产附带的设备ID信息对应。 字段值由用户提供。
        /// </summary>
        [JsonPropertyName("device_ids")]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// device_supply_code, 字段不唯一， 当设备ID重复时可以通过设备类型区分。 501-新能源车类型 可参照融资租赁资产上链文档
        /// </summary>
        [JsonPropertyName("device_supply_code")]
        public long DeviceSupplyCode { get; set; }
    }
}
