using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundJointaccountMemberQueryModel Data Structure.
    /// </summary>
    public class AlipayFundJointaccountMemberQueryModel : AlipayObject
    {
        /// <summary>
        /// 账户ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据。
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
