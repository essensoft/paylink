using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppPropertyAuthSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppPropertyAuthSyncModel : AlipayObject
    {
        /// <summary>
        /// 需要同步的小区认证信息，批量操作时，事务控制，一条数据失败，整个事务回滚。
        /// </summary>
        [JsonProperty("auth_info")]
        public List<PropertyAuthInfo> AuthInfo { get; set; }

        /// <summary>
        /// 认证信息同步操作类型：PUT(新增)、RESET(修改)、REMOVE(删除)。
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }
    }
}
