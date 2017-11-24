using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SsdataFindataOperatorUserinfoCertifyModel Data Structure.
    /// </summary>
    public class SsdataFindataOperatorUserinfoCertifyModel : AlipayObject
    {
        /// <summary>
        /// 系统业务流水号
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户运营商登录信息
        /// </summary>
        [JsonProperty("form_map")]
        public LoginForm FormMap { get; set; }
    }
}
