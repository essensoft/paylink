using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneCommandReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommandReceiveModel : AlipayObject
    {
        /// <summary>
        /// 命令对象
        /// </summary>
        [JsonProperty("command")]
        public Command Command { get; set; }
    }
}
