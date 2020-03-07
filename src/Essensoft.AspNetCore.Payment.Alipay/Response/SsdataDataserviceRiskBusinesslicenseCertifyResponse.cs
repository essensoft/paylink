using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskBusinesslicenseCertifyResponse.
    /// </summary>
    public class SsdataDataserviceRiskBusinesslicenseCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 营业执照的公司地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 业务令牌，由服务端生成后下发，是联系图片认证和非图片认证的桥梁，非图片认证时设置biz_id为上次图片认证调用返回的bis_token，视为一次调用，不会重复计费
        /// </summary>
        [JsonPropertyName("bis_token")]
        public string BisToken { get; set; }

        /// <summary>
        /// 图片本次检测结果，true：认证成功；false：认证未成功
        /// </summary>
        [JsonPropertyName("check_result")]
        public bool CheckResult { get; set; }

        /// <summary>
        /// 企业营业执照统一信用码，每个企业唯一的编号
        /// </summary>
        [JsonPropertyName("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 营业执照法人名称
        /// </summary>
        [JsonPropertyName("ent_legal_name")]
        public string EntLegalName { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 营业执照营业期限
        /// </summary>
        [JsonPropertyName("expires")]
        public string Expires { get; set; }

        /// <summary>
        /// 有效期终止时间
        /// </summary>
        [JsonPropertyName("expires_end")]
        public string ExpiresEnd { get; set; }

        /// <summary>
        /// 有效期起始时间
        /// </summary>
        [JsonPropertyName("expires_start")]
        public string ExpiresStart { get; set; }

        /// <summary>
        /// 返回匹配的字段，多个字段一英文逗号分割 ，企业营业执照统一信用码在底层数据库中为空，字段返回空。
        /// </summary>
        [JsonPropertyName("match_param")]
        public string MatchParam { get; set; }

        /// <summary>
        /// 不匹配的字段，多个字段以英文逗号分割，企业营业执照统一信用码在底层数据库中为空，字段返回空。
        /// </summary>
        [JsonPropertyName("no_match_param")]
        public string NoMatchParam { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
