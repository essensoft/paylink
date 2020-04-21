using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Principal Data Structure.
    /// </summary>
    public class Principal : AlipayObject
    {
        /// <summary>
        /// 用户身份证号。
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型  'IDENTIFY' //个人认证-身份证类型  'BRNUMBER' //工商注册号  'USCC' //统一社会信用代码
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 签约主体类型  individual //个人/操作员  entreprise //企业
        /// </summary>
        [JsonPropertyName("signer_type")]
        public string SignerType { get; set; }

        /// <summary>
        /// 签约主体名称  个人认证时例如：'张三'  企业认证时例如：'XX公司'
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 是否需要认证  'NEED'  //需要认证  'NONEED'  //不需要认证
        /// </summary>
        [JsonPropertyName("verify_type")]
        public string VerifyType { get; set; }
    }
}
