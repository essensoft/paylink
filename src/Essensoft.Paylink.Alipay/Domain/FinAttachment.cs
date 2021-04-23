using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// FinAttachment Data Structure.
    /// </summary>
    public class FinAttachment : AlipayObject
    {
        /// <summary>
        /// 协议编码，当type为AGREEMENT时必填
        /// </summary>
        [JsonPropertyName("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonPropertyName("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件后缀
        /// </summary>
        [JsonPropertyName("file_suffix")]
        public string FileSuffix { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件类型: AGREEMENT：协议 PERSON_ID_CARD_FRONT：法人身份证正面影像件 PERSON_ID_CARD_BACK：法人身份证反面影像件 COMPANY_LICENSE：营业执照影像件
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
