using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpAccountInfo : AlipayObject
    {
        /// <summary>
        /// 机构专户开户银行名称
        /// </summary>
        [JsonProperty("account_inst_name")]
        public string AccountInstName { get; set; }

        /// <summary>
        /// 账户名称（个人对应真实姓名，企业用户对应是企业注册名）
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 开户银行的分支行完整名称
        /// </summary>
        [JsonProperty("inst_branch_name")]
        public string InstBranchName { get; set; }

        /// <summary>
        /// 开户行所在省市信息
        /// </summary>
        [JsonProperty("inst_location")]
        public string InstLocation { get; set; }

        /// <summary>
        /// 机构专户账号
        /// </summary>
        [JsonProperty("sp_account_no")]
        public string SpAccountNo { get; set; }
    }
}
