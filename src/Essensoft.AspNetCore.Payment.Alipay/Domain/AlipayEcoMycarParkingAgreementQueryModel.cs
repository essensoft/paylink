using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingAgreementQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 车牌，用户车辆进场时ISV设备识别到的车辆牌照
        /// </summary>
        [JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 接口版本号，不填则默认为v2.0，建议使用最新版v2.1
        /// </summary>
        [JsonProperty("ver")]
        public string Ver { get; set; }
    }
}
