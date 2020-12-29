using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerUserQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinCustomerUserQueryModel : AlipayObject
    {
        /// <summary>
        /// DCHAIN("DCHAIN","供应链信用流转平台"), ABS("ABS","ABS资产流转平台"), BAMBOO("BAMBOO","BAMBOO项目"), LOGISTICS_FIN("LOGISTICS_FIN", "物流金融"), TRUSPLE("TRUSPLE", "跨境贸易金融平台");
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 通过角色类型查询用户信息
        /// </summary>
        [JsonPropertyName("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 操作员邮箱
        /// </summary>
        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
