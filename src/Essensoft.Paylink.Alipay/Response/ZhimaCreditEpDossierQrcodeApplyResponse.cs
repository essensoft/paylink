using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierQrcodeApplyResponse.
    /// </summary>
    public class ZhimaCreditEpDossierQrcodeApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 档案直跳地址，默认不返回
        /// </summary>
        [JsonPropertyName("dossier_path")]
        public string DossierPath { get; set; }

        /// <summary>
        /// 二维码到期时间， 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// 企业档案页二维码图片地址
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }
    }
}
