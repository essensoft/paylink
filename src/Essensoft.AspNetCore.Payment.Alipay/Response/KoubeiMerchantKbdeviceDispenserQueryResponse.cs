using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDispenserQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbdeviceDispenserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 取餐柜设备是否可用
        /// </summary>
        [JsonPropertyName("availability")]
        public bool Availability { get; set; }

        /// <summary>
        /// 取餐柜的单元格详情列表
        /// </summary>
        [JsonPropertyName("cell_info_list")]
        public List<FoodDispenserCellInfo> CellInfoList { get; set; }

        /// <summary>
        /// 取餐柜的唯一设备ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }
    }
}
