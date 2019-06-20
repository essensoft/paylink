using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantMenber Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantMenber : AlipayObject
    {
        /// <summary>
        /// 生日 yyyy-MM-dd
        /// </summary>
        [JsonProperty("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("cell")]
        public string Cell { get; set; }

        /// <summary>
        /// 性别（男：MALE；女：FEMALE）
        /// </summary>
        [JsonProperty("gende")]
        public string Gende { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
