using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdFacepayUploadResponse.
    /// </summary>
    public class AlipaySecurityProdFacepayUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 人脸支付token。即商户在本接口提交的用户人脸图片对应的token，通过此token串联后续调用
        /// </summary>
        [JsonPropertyName("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 用户标识提示。例如提示用户输入手机号时，可返回用户手机号的前7位。当此项为空时，说明在热点人脸库中没有搜索成功，需要用户填写其标识的全部位；当此项不为空时，说明在热点人脸库中成功匹配，客户端需要给用户展示标识提示位，由用户补全剩余位
        /// </summary>
        [JsonPropertyName("user_auth_id_hint")]
        public string UserAuthIdHint { get; set; }

        /// <summary>
        /// 用户标识类型。目前支持手机号码，即mobile
        /// </summary>
        [JsonPropertyName("user_auth_id_type")]
        public string UserAuthIdType { get; set; }
    }
}
