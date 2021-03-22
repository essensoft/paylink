using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetDevicelistQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceAssetDevicelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 资产所有人标示
        /// </summary>
        [JsonPropertyName("asset_owner")]
        public string AssetOwner { get; set; }

        /// <summary>
        /// 需要查询的设备ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备物料类型，当设备ID重复时，可通过该字段区分。 具体取值可以参考金融资产上链文档。
        /// </summary>
        [JsonPropertyName("device_supply_type")]
        public string DeviceSupplyType { get; set; }
    }
}
