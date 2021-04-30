using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 特约商户进件 - 提交申请单 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter11_1_1.shtml">特约商户进件 - 提交申请单API</a> - 最新更新时间：2021.04.06</para>
    /// </remarks>
    public class WeChatPayApplyment4SubApplymentBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 业务申请编号
        /// </summary>
        /// <remarks>
        /// 1、服务商自定义的唯一编号。
        /// 2、每个编号对应一个申请单，每个申请单审核通过后会生成一个微信支付商户号。
        /// 3、若申请单被驳回，可填写相同的“业务申请编号”，即可覆盖修改原申请单信息。
        /// <para>示例值：APPLYMENT_00000000001</para>
        /// </remarks>
        [JsonPropertyName("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 超级管理员信息
        /// </summary>
        /// <remarks>
        /// 超级管理员需在开户后进行签约，并接收日常重要管理信息和进行资金操作，请确定其为商户法定代表人或负责人。
        /// </remarks>
        [JsonPropertyName("contact_info")]
        public ContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 主体资料
        /// </summary>
        /// <remarks>
        /// 请填写商家的营业执照/登记证书、经营者/法人的证件等信息。
        /// </remarks>
        [JsonPropertyName("subject_info")]
        public SubjectInfo SubjectInfo { get; set; }

        /// <summary>
        /// 经营资料
        /// </summary>
        /// <remarks>
        /// 请填写商家的经营业务信息、售卖商品/提供服务场景信息。
        /// </remarks>
        [JsonPropertyName("business_info")]
        public BusinessInfo BusinessInfo { get; set; }

        /// <summary>
        /// 结算规则
        /// </summary>
        /// <remarks>
        /// 请填写商家的结算费率规则、特殊资质等信息。
        /// </remarks>
        [JsonPropertyName("settlement_info")]
        public SettlementInfo SettlementInfo { get; set; }

        /// <summary>
        /// 结算银行账户
        /// </summary>
        /// <remarks>
        /// 请填写商家提现收款的银行账户信息。
        /// </remarks>
        [JsonPropertyName("bank_account_info")]
        public BankAccountInfo BankAccountInfo { get; set; }

        /// <summary>
        /// 补充材料
        /// </summary>
        /// <remarks>
        /// 根据实际审核情况，额外要求商家提供指定的补充资料。
        /// </remarks>
        [JsonPropertyName("addition_info")]
        public AdditionInfo AdditionInfo { get; set; }
    }
}
