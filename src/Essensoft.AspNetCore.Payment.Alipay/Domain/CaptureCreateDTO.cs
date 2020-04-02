using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CaptureCreateDTO Data Structure.
    /// </summary>
    public class CaptureCreateDTO : AlipayObject
    {
        /// <summary>
        /// 请款单号
        /// </summary>
        [JsonPropertyName("capture_no")]
        public string CaptureNo { get; set; }

        /// <summary>
        /// 外部业务请求号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
