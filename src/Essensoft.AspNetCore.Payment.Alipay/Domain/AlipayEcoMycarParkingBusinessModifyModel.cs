using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingBusinessModifyModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingBusinessModifyModel : AlipayObject
    {
        /// <summary>
        /// 停车场无感业务归属appid。appid在停车平台配置过ISV信息。
        /// </summary>
        [JsonPropertyName("agreement_appid")]
        public string AgreementAppid { get; set; }

        /// <summary>
        /// 支付宝返回停车场id
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }
    }
}
