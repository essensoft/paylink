using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingCardbarcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingCardbarcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 设备商订单id
        /// </summary>
        [JsonPropertyName("equipment_id")]
        public string EquipmentId { get; set; }

        /// <summary>
        /// 支付宝交易流水号订单
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }
    }
}
