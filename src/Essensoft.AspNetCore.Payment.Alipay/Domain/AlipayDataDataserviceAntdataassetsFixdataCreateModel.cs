using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsFixdataCreateModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsFixdataCreateModel : AlipayObject
    {
        /// <summary>
        /// 该字段指定补数据的结束分区
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// 该字段指定补数据的开始分区
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
