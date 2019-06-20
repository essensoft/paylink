using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceDataLogdataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataLogdataSyncModel : AlipayObject
    {
        /// <summary>
        /// 商户自定义监控原始日志数据
        /// </summary>
        [JsonProperty("log")]
        public string Log { get; set; }

        /// <summary>
        /// 命名空间，商户与支付宝进行监控共建场景使用，命令空间需要先在云监控自定义监控页面配置录入。
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }
}
