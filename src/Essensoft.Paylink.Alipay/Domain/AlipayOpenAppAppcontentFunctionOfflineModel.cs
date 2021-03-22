using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionOfflineModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentFunctionOfflineModel : AlipayObject
    {
        /// <summary>
        /// 服务编码，通过 <a href="https://opendocs.alipay.com/apis/011agl">alipay.open.app.appcontent.function.create</a>(小程序服务创建)接口创建服务后获取。
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
