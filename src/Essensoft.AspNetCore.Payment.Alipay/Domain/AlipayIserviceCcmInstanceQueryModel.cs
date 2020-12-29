using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmInstanceQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmInstanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数，最大值 100 行，默认为 10
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
