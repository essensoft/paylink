using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarViolationVehicleQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarViolationVehicleQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户车辆ID,支付宝系统唯一
        /// </summary>
        [JsonProperty("vi_id")]
        public string ViId { get; set; }
    }
}
