using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 结算银行账户
    /// </summary>
    public class BankAccountInfo : WeChatPayObject
    {
        /// <summary>
        /// 账户类型
        /// </summary>
        /// <remarks>
        /// 1、若主体为企业/党政、机关及事业单位/其他组织，可填写：对公银行账户。
        /// 2、若主体为个体户，可选择填写：对公银行账户或经营者个人银行卡。
        /// 枚举值：
        /// BANK_ACCOUNT_TYPE_CORPORATE：对公银行账户
        /// BANK_ACCOUNT_TYPE_PERSONAL：经营者个人银行卡
        /// <para>示例值：BANK_ACCOUNT_TYPE_CORPORATE</para>
        /// </remarks>
        [JsonPropertyName("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// 开户名称
        /// </summary>
        /// <remarks>
        /// 1、选择“经营者个人银行卡”时，开户名称必须与“经营者证件姓名”一致。
        /// 2、选择“对公银行账户”时，开户名称必须与营业执照/登记证书的“商户名称”一致。
        /// 3、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">《敏感信息加密说明》</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：AOZdYGISxo4y4+kyblK2FCCqQJJp0/0eow96uY1Pk7Rq79Jtt7+I8juwEc4P4TG5xzchG/5IL9DBd+Z0zZXkw==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        /// <remarks>
        /// 开户银行，详细参见《开户银行对照表》。
        /// <para>示例值：工商银行</para>
        /// </remarks>
        [JsonPropertyName("account_bank")]
        public string AccountBank { get; set; }

        /// <summary>
        /// 开户银行省市编码
        /// </summary>
        /// <remarks>
        /// 至少精确到市，详细参见《省市区编号对照表》。
        /// <para>示例值：110000</para>
        /// </remarks>
        [JsonPropertyName("bank_address_code")]
        public string BankAddressCode { get; set; }

        /// <summary>
        /// 开户银行联行号
        /// </summary>
        /// <remarks>
        /// 1、17家直连银行无需填写，如为其他银行，则开户银行全称（含支行）和开户银行联行号二选一。
        /// 2、详细参见《开户银行全称（含支行）对照表》。
        /// <para>示例值：402713354941</para>
        /// </remarks>
        [JsonPropertyName("bank_branch_id")]
        public string BankBranchId { get; set; }

        /// <summary>
        /// 开户银行全称（含支行）
        /// </summary>
        /// <remarks>
        /// 1、17家直连银行无需填写，如为其他银行，则开户银行全称（含支行）和 开户银行联行号二选一。
        /// 2、需填写银行全称，如"深圳农村商业银行XXX支行"，详细参见《开户银行全称（含支行）对照表》。
        /// <para>示例值：施秉县农村信用合作联社城关信用社</para>
        /// </remarks>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        /// <remarks>
        /// 1、数字，长度遵循系统支持的卡号长度要求表。
        /// 2、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">《敏感信息加密说明》</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：d+xT+MQCvrLHUVDWC1PHN4C7Rsu3WL8sPndjXTd75kPkyjqnoMRrEEaYQE8ZRGYoeorwC+w==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 银行账户证明材料
        /// </summary>
        /// <remarks>
        ///1. 当主体类型是“政府机关/事业单位”时或所属行业为“党费”时，支持在有合法资金管理关系的情况下结算账户设置为非同名。
        ///2. 若结算账户设置为非同名，则需填写非同名证明材料，若结算账户为同名，则无需填写。
        /// </remarks>
        [JsonPropertyName("account_cert_info")]
        public AccountCertInfo AccountCertInfo { get; set; }
    }
}
