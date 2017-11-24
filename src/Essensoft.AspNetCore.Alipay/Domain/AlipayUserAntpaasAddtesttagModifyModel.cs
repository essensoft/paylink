using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntpaasAddtesttagModifyModel Data Structure.
    /// </summary>
    public class AlipayUserAntpaasAddtesttagModifyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账户id
        /// </summary>
        [JsonProperty("account_no")]
        public string AccountNo { get; set; }
    }
}
