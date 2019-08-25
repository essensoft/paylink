using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsFixdataCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntdataassetsFixdataCreateModel : AlipayObject
    {
        /// <summary>
        /// 该字段指定补数据的结束分区
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// 该字段指定补数据的开始分区
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
