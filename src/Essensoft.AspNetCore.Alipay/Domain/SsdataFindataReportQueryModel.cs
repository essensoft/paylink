using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SsdataFindataReportQueryModel Data Structure.
    /// </summary>
    public class SsdataFindataReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户在调用产品的第一个接口时系统返回的业务流水号
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
