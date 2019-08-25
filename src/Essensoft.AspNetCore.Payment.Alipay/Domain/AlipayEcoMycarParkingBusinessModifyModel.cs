using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingBusinessModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingBusinessModifyModel : AlipayObject
    {
        /// <summary>
        /// 停车场无感业务归属appid。appid在停车平台配置过ISV信息。
        /// </summary>
        [JsonProperty("agreement_appid")]
        public string AgreementAppid { get; set; }

        /// <summary>
        /// 支付宝返回停车场id
        /// </summary>
        [JsonProperty("parking_id")]
        public string ParkingId { get; set; }
    }
}
