using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SsdataFindataOperatorSmsQueryModel Data Structure.
    /// </summary>
    public class SsdataFindataOperatorSmsQueryModel : AlipayObject
    {
        /// <summary>
        /// 系统的业务流水号，在调用提交用户信息时得到的biz_no
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
