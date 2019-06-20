using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserInfoFromNJ Data Structure.
    /// </summary>
    [Serializable]
    public class UserInfoFromNJ : AlipayObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonProperty("tel")]
        public string Tel { get; set; }
    }
}
