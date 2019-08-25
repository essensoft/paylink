using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorSearchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorSearchQueryModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 操作员所属部门id集合
        /// </summary>
        [JsonProperty("dept_ids")]
        public List<string> DeptIds { get; set; }

        /// <summary>
        /// 操作员对应的部门树集合，以“/”分割，最前面的为根部门id，
        /// </summary>
        [JsonProperty("dept_paths")]
        public List<string> DeptPaths { get; set; }

        /// <summary>
        /// 当前查询页数
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，每页10条
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 操作员角色id列表，可以根据角色id列表查询关联的操作员列表
        /// </summary>
        [JsonProperty("role_ids")]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// 模糊查询字段，支持操作员的姓名，别名，手机模糊查询
        /// </summary>
        [JsonProperty("search_key")]
        public string SearchKey { get; set; }

        /// <summary>
        /// 操作员的状态列表，T为激活，W为未激活
        /// </summary>
        [JsonProperty("status")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 是否查询的是待分配列表，商户的存量数据没有部门关联，设置unassign为true，可以把存量的操作员查出来
        /// </summary>
        [JsonProperty("unassign")]
        public bool Unassign { get; set; }
    }
}
