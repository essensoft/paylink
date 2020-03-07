using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCertifyVerifyIdcardResponse.
    /// </summary>
    public class AlipayCertifyVerifyIdcardResponse : AlipayResponse
    {
        /// <summary>
        /// 校验结果JSON串
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// * 00  公民身份号码与姓名一致，且存在照片,上传照片，返回匹配  * 01  公民身份号码与姓名一致，但不存在照片，返回匹配  * 02  公民身份号码存在，但与姓名不匹配，返回不匹配  * 03  公民身份号码不存在，返回没有此人  * 04  其他错误，返回第三方错误  * 05  输入的参数错误，返回第三方错误
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
