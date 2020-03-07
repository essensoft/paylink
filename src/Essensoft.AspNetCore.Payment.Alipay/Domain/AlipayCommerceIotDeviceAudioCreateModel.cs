using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceAudioCreateModel : AlipayObject
    {
        /// <summary>
        /// 文本内容. 文本的最大长度为25个字符.注意: 语音合成不支持英文字母和!,@,#,$,%,^...等特殊字符, 如果包含则会自动过滤
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
