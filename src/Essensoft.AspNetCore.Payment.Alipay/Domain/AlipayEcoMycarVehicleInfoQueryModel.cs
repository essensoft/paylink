using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehicleInfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarVehicleInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("plate_no")]
        public string PlateNo { get; set; }
    }
}
