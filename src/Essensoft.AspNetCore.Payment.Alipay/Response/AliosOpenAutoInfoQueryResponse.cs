using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AliosOpenAutoInfoQueryResponse.
    /// </summary>
    public class AliosOpenAutoInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonProperty("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 车辆识别号码
        /// </summary>
        [JsonProperty("vin")]
        public string Vin { get; set; }
    }
}
