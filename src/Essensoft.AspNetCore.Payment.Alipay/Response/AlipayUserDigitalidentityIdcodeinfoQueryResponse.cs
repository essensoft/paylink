using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserDigitalidentityIdcodeinfoQueryResponse.
    /// </summary>
    public class AlipayUserDigitalidentityIdcodeinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用数据提供机构RSA加密后的AES秘钥，加密后进行了Base64编码。机构的公钥请接入时商户与机构线下对接，加解密签名验签工具请接入时与支付宝端本开放能力技术负责人对接获取。当user_data不为空时必填
        /// </summary>
        [JsonPropertyName("aes_key_encrypted")]
        public string AesKeyEncrypted { get; set; }

        /// <summary>
        /// 核验身份码成功后返回AES加密后的用户信息（Base64编码），解密后为Map的JSON串，具体内容格式视业务场景而不同。仅当身份码核验通过且商户拥有查询用户信息权限时该字段有值
        /// </summary>
        [JsonPropertyName("user_data")]
        public string UserData { get; set; }

        /// <summary>
        /// 对userData原始信息的签名。加解密签名验签工具请接入时与支付宝端本开放能力技术负责人对接获取。user_data不为空时必填
        /// </summary>
        [JsonPropertyName("user_data_sign")]
        public string UserDataSign { get; set; }

        /// <summary>
        /// 身份码核验结果，成功返回success，失败返回fail。 1）success：校验成功（二维码有效、正确且用户拥有该二维码） 2）fail：校验失败
        /// </summary>
        [JsonPropertyName("verify_result")]
        public string VerifyResult { get; set; }
    }
}
