using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateAuthenticateCampuscardDeleteResponse.
    /// </summary>
    public class AlipayCommerceEducateAuthenticateCampuscardDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 如果学生学籍更新成功，则返回SUCCESS ， 失败返回FAIL。
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
