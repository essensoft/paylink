using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInspectCreateResponse.
    /// </summary>
    public class AlipayEbppInspectCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 外部业务标识，同入参的out_biz_no
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
