using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayCreditAutofinanceVidGetModel Data Structure.
    /// </summary>
    public class AlipayCreditAutofinanceVidGetModel : AlipayObject
    {
        /// <summary>
        /// 机构编号
        /// </summary>
        [JsonProperty("orgcode")]
        public string Orgcode { get; set; }

        /// <summary>
        /// 支付宝账号数字ID
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 当前安装的支付宝钱包版本号
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
