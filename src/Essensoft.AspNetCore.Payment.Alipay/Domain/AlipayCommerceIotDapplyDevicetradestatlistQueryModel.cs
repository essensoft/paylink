using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyDevicetradestatlistQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDapplyDevicetradestatlistQueryModel : AlipayObject
    {
        /// <summary>
        /// 分页起始偏移
        /// </summary>
        [JsonPropertyName("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询范围截止日期
        /// </summary>
        [JsonPropertyName("stat_end")]
        public string StatEnd { get; set; }

        /// <summary>
        /// 查询范围起始值
        /// </summary>
        [JsonPropertyName("stat_start")]
        public string StatStart { get; set; }
    }
}
