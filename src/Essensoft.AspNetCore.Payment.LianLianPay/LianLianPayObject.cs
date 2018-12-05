using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    /// <summary>
    /// LianLianPay 基础对象。
    /// </summary>
    public abstract class LianLianPayObject
    {
        /// <summary>
        /// 响应原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 响应原始参数
        /// </summary>
        [JsonIgnore]
        public LianLianPayDictionary Parameters { get; internal set; }
    }
}
