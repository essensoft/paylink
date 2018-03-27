using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingLotbarcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingLotbarcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 停车场编号
        /// </summary>
        [JsonProperty("parking_id")]
        public string ParkingId { get; set; }
    }
}
