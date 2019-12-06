using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineVehicleQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarDialogonlineVehicleQueryModel : AlipayObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [JsonPropertyName("vi_id")]
        public string ViId { get; set; }
    }
}
