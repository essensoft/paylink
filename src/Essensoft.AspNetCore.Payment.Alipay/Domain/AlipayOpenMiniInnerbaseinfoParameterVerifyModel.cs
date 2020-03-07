using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoParameterVerifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoParameterVerifyModel : AlipayObject
    {
        /// <summary>
        /// 校验小程序基本信息枚举  APP_NAME 小程序名称  APP_ENGLISH_NAME 小程序英文名
        /// </summary>
        [JsonPropertyName("verify_type")]
        public string VerifyType { get; set; }

        /// <summary>
        /// 小程序基本参数校验数据
        /// </summary>
        [JsonPropertyName("verify_value")]
        public string VerifyValue { get; set; }
    }
}
