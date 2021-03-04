using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateAuthenticateCampuscardModifyResponse.
    /// </summary>
    public class AlipayCommerceEducateAuthenticateCampuscardModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 如果学生学籍更新成功，则返回SUCCESS ， 失败返回FAIL。
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
