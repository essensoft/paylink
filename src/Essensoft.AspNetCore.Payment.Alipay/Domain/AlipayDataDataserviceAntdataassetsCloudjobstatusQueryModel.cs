using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsCloudjobstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntdataassetsCloudjobstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 分区信息
        /// </summary>
        [JsonProperty("bizdate")]
        public string Bizdate { get; set; }

        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; }
    }
}
