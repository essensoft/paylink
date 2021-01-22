using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 提交申请单API(普通服务商) - 请求JSON参数
    /// 最新更新时间：2019.04.10
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_1.shtml
    /// </summary>
    public class WeChatPayApplyment4SubApplymentBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 业务申请编号
        /// 1、服务商自定义的唯一编号。
        /// 2、每个编号对应一个申请单，每个申请单审核通过后会生成一个微信支付商户号。
        /// 3、若申请单被驳回，可填写相同的“业务申请编号”，即可覆盖修改原申请单信息。
        /// 示例值：APPLYMENT_00000000001
        /// </summary>
        [JsonPropertyName("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 超级管理员信息
        /// 超级管理员需在开户后进行签约，并接收日常重要管理信息和进行资金操作，请确定其为商户法定代表人或负责人。
        /// </summary>
        [JsonPropertyName("contact_info")]
        public ContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 主体资料
        /// 请填写商家的营业执照/登记证书、经营者/法人的证件等信息。
        /// </summary>
        [JsonPropertyName("subject_info")]
        public SubjectInfo SubjectInfo { get; set; }

        /// <summary>
        /// 经营资料
        /// 请填写商家的经营业务信息、售卖商品/提供服务场景信息。
        /// </summary>
        [JsonPropertyName("business_info")]
        public BusinessInfo BusinessInfo { get; set; }

        /// <summary>
        /// 结算规则
        /// 请填写商家的结算费率规则、特殊资质等信息。
        /// </summary>
        [JsonPropertyName("settlement_info")]
        public SettlementInfo SettlementInfo { get; set; }

        /// <summary>
        /// 结算银行账户
        ///  1、请填写商家提现收款的银行账户信息。
        ///  2、若结算规则id为“719、721、716、717、730、739、727、738、726”，可选填结算账户。
        /// </summary>
        [JsonPropertyName("bank_account_info")]
        public BankAccountInfo BankAccountInfo { get; set; }

        /// <summary>
        /// 补充材料
        /// 根据实际审核情况，额外要求商家提供指定的补充资料。
        /// </summary>
        [JsonPropertyName("addition_info")]
        public AdditionInfo AdditionInfo { get; set; }
    }
}
