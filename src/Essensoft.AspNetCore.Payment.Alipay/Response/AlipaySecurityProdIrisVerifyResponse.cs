using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdIrisVerifyResponse.
    /// </summary>
    public class AlipaySecurityProdIrisVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 虹膜校验关联token，用于二次校验
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 虹膜扩展参数，用于后续扩展，目前没有内容
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 对此次搜索虹膜库分组的虹膜id标识
        /// </summary>
        [JsonPropertyName("iris_id")]
        public string IrisId { get; set; }

        /// <summary>
        /// 用于标识虹膜对应的注册人的id，如支付宝的uid、信用id等等，此处返回虹膜注册时候传入的person_id
        /// </summary>
        [JsonPropertyName("person_id")]
        public string PersonId { get; set; }

        /// <summary>
        /// 用于标识本次虹膜校验状态，虹膜校验需要将服务端的校验状态细节同时返回给业务方，-1冻结，-2多个虹膜匹配，17匹配到虹膜
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
