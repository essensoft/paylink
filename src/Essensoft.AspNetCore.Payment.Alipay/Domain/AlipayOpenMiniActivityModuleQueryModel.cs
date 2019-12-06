using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniActivityModuleQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniActivityModuleQueryModel : AlipayObject
    {
        /// <summary>
        /// 地区码，比如杭州的城市码是300100
        /// </summary>
        [JsonPropertyName("lbs_code")]
        public string LbsCode { get; set; }

        /// <summary>
        /// 模块编码，模块的唯一标识，可根据该编码查询模块数据信息
        /// </summary>
        [JsonPropertyName("module_code")]
        public string ModuleCode { get; set; }

        /// <summary>
        /// 页码，代表请求的是第几页的数据
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数量，代表每页请求的数据的数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
