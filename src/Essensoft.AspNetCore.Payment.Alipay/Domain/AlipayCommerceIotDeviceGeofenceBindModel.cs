using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceGeofenceBindModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceGeofenceBindModel : AlipayObject
    {
        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 一组地理围栏的唯一标识, 通常一条公交线路.  一个设备只能绑定一条线路; 如果设备多次绑定线路, 以最新的线路为准; 如果不传route_code,表示将设备与现有线路解除绑定
        /// </summary>
        [JsonPropertyName("route_code")]
        public string RouteCode { get; set; }
    }
}
