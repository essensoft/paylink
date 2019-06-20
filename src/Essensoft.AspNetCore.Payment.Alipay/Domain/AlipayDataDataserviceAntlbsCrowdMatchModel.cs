using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntlbsCrowdMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntlbsCrowdMatchModel : AlipayObject
    {
        /// <summary>
        /// crowd_code ＋ 客群匹配接口 ＋ 客群码，创建客群时可获取
        /// </summary>
        [JsonProperty("crowd_code")]
        public List<string> CrowdCode { get; set; }

        /// <summary>
        /// scene_code ＋ 客群匹配接口 ＋ 客群归属的场景，在icrowd平台上可以看到
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// uid ＋ 客群匹配接口 ＋ 用户唯一ID，目前只支持支付宝账号，其他ID类型请联系接口负责人确认是否支持
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// uid_type ＋ 客群匹配接口 ＋ ID类型，目前只支持支付宝账号（USER_ID），其他ID类型请联系接口负责人确认是否支持
        /// </summary>
        [JsonProperty("uid_type")]
        public string UidType { get; set; }
    }
}
