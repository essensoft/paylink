using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SsdataFindataOperatorImgQueryModel Data Structure.
    /// </summary>
    public class SsdataFindataOperatorImgQueryModel : AlipayObject
    {
        /// <summary>
        /// 系统业务流水号，在提交用户信息时获得
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
