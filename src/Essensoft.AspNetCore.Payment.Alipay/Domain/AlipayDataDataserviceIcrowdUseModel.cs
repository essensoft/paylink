using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceIcrowdUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceIcrowdUseModel : AlipayObject
    {
        /// <summary>
        /// icrowd接口请求参数＋唯一不可空
        /// </summary>
        [JsonProperty("icrowd_use_param")]
        public IcrowdUseParam IcrowdUseParam { get; set; }
    }
}
