using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDispenserQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantKbdeviceDispenserQueryModel : AlipayObject
    {
        /// <summary>
        /// 取餐柜的唯一设备ID。通过<a href="https://opendocs.alipay.com/apis/api_3/koubei.merchant.kbdevice.devices.batchquery"> koubei.merchant.kbdevice.devices.batchquery</a>(查询门店下设备列表) 接口查询获得。
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }
    }
}
