using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetDevicelistQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetDevicelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询的设备信息列表，为空表示未查询到结果。
        /// </summary>
        [JsonPropertyName("device_list")]
        public List<AssetDeviceRelation> DeviceList { get; set; }
    }
}
