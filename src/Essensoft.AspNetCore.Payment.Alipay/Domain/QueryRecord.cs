using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryRecord Data Structure.
    /// </summary>
    public class QueryRecord : AlipayObject
    {
        /// <summary>
        /// 企业编号
        /// </summary>
        [JsonPropertyName("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 操作人(经办人/实际签约人)姓名
        /// </summary>
        [JsonPropertyName("opr_cert_name")]
        public string OprCertName { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [JsonPropertyName("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 签约顺序(0:  初始发起签约;   1：第1方签约;  2：第2方签约)
        /// </summary>
        [JsonPropertyName("sign_order")]
        public long SignOrder { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonPropertyName("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 操作类型英文code(INIT: 发起签约;  CANCEL: 撤销签约;  APPROVE: 确认签约)
        /// </summary>
        [JsonPropertyName("sign_type_code")]
        public string SignTypeCode { get; set; }
    }
}
