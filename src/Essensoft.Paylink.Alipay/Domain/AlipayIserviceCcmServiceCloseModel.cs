using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmServiceCloseModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmServiceCloseModel : AlipayObject
    {
        /// <summary>
        /// 服务代码。通过<a href="https://opendocs.alipay.com/apis/01dmgh">alipay.iservice.ccm.service.initialize</a>(isv服务初始化接口) 获取。
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
