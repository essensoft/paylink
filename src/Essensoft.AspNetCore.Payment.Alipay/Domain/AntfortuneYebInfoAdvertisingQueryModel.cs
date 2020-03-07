using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneYebInfoAdvertisingQueryModel Data Structure.
    /// </summary>
    public class AntfortuneYebInfoAdvertisingQueryModel : AlipayObject
    {
        /// <summary>
        /// 参数名:mobile  应用场景:外部渠道传递手机号，由余额宝来判断是否需要进行投放并告知外部渠道  如何获取：外部渠道自己获取传过来
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }
    }
}
