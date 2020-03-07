using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInstcardBindModel Data Structure.
    /// </summary>
    public class AlipayCommerceMedicalInstcardBindModel : AlipayObject
    {
        /// <summary>
        /// 区域编码，使用国家行政区划代码，可参看  http://www.stats.gov.cn/tjsj/tjbz/xzqhdm
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 业务扩展参数  sys_service_provider_id:返佣商户标记  serial_no:商户业务序列号  return_params:外部商户提交给支付宝处理的请求参数,支付宝在整个处理过程中携带此参数。
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 机构编号
        /// </summary>
        [JsonPropertyName("ins_code")]
        public string InsCode { get; set; }

        /// <summary>
        /// 支付宝处理完请求后，如验证成功，当前页面自动跳转到商户网站里指定页面的http路径。
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
