using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperatorInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorInfoModel : AlipayObject
    {
        /// <summary>
        /// customerId
        /// </summary>
        [JsonProperty("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 邮件
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [JsonProperty("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 部门树
        /// </summary>
        [JsonProperty("job_tree")]
        public string JobTree { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作员别名
        /// </summary>
        [JsonProperty("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员类型
        /// </summary>
        [JsonProperty("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonProperty("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名字
        /// </summary>
        [JsonProperty("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 门店列表
        /// </summary>
        [JsonProperty("shop_ids")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// T
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
