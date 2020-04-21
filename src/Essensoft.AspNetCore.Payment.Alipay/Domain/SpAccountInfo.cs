using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpAccountInfo Data Structure.
    /// </summary>
    public class SpAccountInfo : AlipayObject
    {
        /// <summary>
        /// 机构专户开户银行名称
        /// </summary>
        [JsonPropertyName("account_inst_name")]
        public string AccountInstName { get; set; }

        /// <summary>
        /// 账户名称（个人对应真实姓名，企业用户对应是企业注册名）
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 开户银行的分支行完整名称
        /// </summary>
        [JsonPropertyName("inst_branch_name")]
        public string InstBranchName { get; set; }

        /// <summary>
        /// 开户行所在省市信息
        /// </summary>
        [JsonPropertyName("inst_location")]
        public string InstLocation { get; set; }

        /// <summary>
        /// 机构专户账号
        /// </summary>
        [JsonPropertyName("sp_account_no")]
        public string SpAccountNo { get; set; }
    }
}
