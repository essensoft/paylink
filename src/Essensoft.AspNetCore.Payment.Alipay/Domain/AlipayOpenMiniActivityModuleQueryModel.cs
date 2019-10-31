using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniActivityModuleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniActivityModuleQueryModel : AlipayObject
    {
        /// <summary>
        /// 地区码，比如杭州的城市码是300100
        /// </summary>
        [JsonProperty("lbs_code")]
        public string LbsCode { get; set; }

        /// <summary>
        /// 模块编码，模块的唯一标识，可根据该编码查询模块数据信息
        /// </summary>
        [JsonProperty("module_code")]
        public string ModuleCode { get; set; }

        /// <summary>
        /// 页码，代表请求的是第几页的数据
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数量，代表每页请求的数据的数量
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
