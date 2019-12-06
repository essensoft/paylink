using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyArrangementQueryModel Data Structure.
    /// </summary>
    public class MybankCreditLoanapplyArrangementQueryModel : AlipayObject
    {
        /// <summary>
        /// 产品代码，标识网商银行具体的产品，由网商银行预先分配好，接入方按网商银行的要求送。
        /// </summary>
        [JsonPropertyName("ar_pd_code")]
        public string ArPdCode { get; set; }

        /// <summary>
        /// 客户id，网商银行唯一标识一个客户的id。此客户id是通过客户创建接口返回的。即调用此接口前必须先调用客户创建接口。
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 客户角色id，网商银行唯一标识一个客户角色的id。此id是通过客户创建接口返回的。即调用此接口前必须先调用客户创建接口。客户角色id+产品代码唯一确定一笔签约。
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 站点类型，当前只支持ALIPAY。后续扩展可以支持TAOBAO等。目前这个字段必须传递ALIPAY。
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点数字id，例如支付宝id、淘宝id。接入方通过客户的支付宝或淘宝账号获取对应的userId。当site为ALIPAY时，site_user_id必须是支付宝userid
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
