using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeRoominfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeRoominfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 传入该小区在支付宝社区物业平台中的唯一编号，通过小区创建和查询接口获取。
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 分页查询的页码数，分页从1开始计数。该参数不传入的时候，默认为1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页最大数据条数。默认为200
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
