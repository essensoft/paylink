using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceBusinessorderQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceBusinessorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询办事记录的时间区间中的开始时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 查询办事记录的时间区间中的结束时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// isv的appid
        /// </summary>
        [JsonPropertyName("isv_appid")]
        public string IsvAppid { get; set; }

        /// <summary>
        /// 分页查询的起始页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页数据量
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 查询的办事记录所属服务展台（如城市服务为CITY_SERVICE，车主平台为MYCAR_SERVICE等）
        /// </summary>
        [JsonPropertyName("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 办事记录状态列表
        /// </summary>
        [JsonPropertyName("status_list")]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
