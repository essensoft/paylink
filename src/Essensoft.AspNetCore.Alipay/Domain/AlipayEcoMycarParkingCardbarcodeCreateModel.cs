using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingCardbarcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingCardbarcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 设备商订单id
        /// </summary>
        [JsonProperty("equipment_id")]
        public string EquipmentId { get; set; }

        /// <summary>
        /// 支付宝交易流水号订单
        /// </summary>
        [JsonProperty("parking_id")]
        public string ParkingId { get; set; }
    }
}
