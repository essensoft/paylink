using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntforestPlantApplyResponse.
    /// </summary>
    public class AlipaySocialAntforestPlantApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 时间戳，记录的是业务在蚂蚁森林完成时间，可保存用户核对
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 证书ID或者其他ID，表示一次兑换的凭证
        /// </summary>
        [JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 当前兑换树种账户的可用能量值
        /// </summary>
        [JsonPropertyName("current_energy")]
        public long CurrentEnergy { get; set; }
    }
}
