using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FileSignature Data Structure.
    /// </summary>
    public class FileSignature : AlipayObject
    {
        /// <summary>
        /// 签约主体证件号，关联principal对象
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 图章id/图章模板id
        /// </summary>
        [JsonPropertyName("seal_id")]
        public string SealId { get; set; }

        /// <summary>
        /// 签章位置描述
        /// </summary>
        [JsonPropertyName("seal_position")]
        public SealPosition SealPosition { get; set; }

        /// <summary>
        /// 电子图章类型  1 : 图章模板自动合成  2 : 托管图章编号
        /// </summary>
        [JsonPropertyName("seal_type")]
        public long SealType { get; set; }

        /// <summary>
        /// 签约原因描述，可展示在PDF签名区
        /// </summary>
        [JsonPropertyName("sign_reason")]
        public string SignReason { get; set; }

        /// <summary>
        /// 电子签章类型   1:仅数字证书文档签名  2:仅图章  3:数字证书文档签名，加盖图章
        /// </summary>
        [JsonPropertyName("signature_type")]
        public long SignatureType { get; set; }
    }
}
