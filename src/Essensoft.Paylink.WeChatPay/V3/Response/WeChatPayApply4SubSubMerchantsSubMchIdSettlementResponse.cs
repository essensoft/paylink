using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 特约商户进件 - 提交申请单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter11_1_1.shtml">特约商户进件 - 提交申请单API</a> - 最新更新时间：2019.04.10</para>
    /// </remarks>
    public class WeChatPayApply4SubSubMerchantsSubMchIdSettlementResponse : WeChatPayResponse
    {
        /// <summary>
        /// 账户类型
        /// </summary>
        /// <remarks>
        /// 返回特约商户的结算账户类型。
        /// 枚举值：
        /// ACCOUNT_TYPE_BUSINESS：对公银行账户
        /// ACCOUNT_TYPE_PRIVATE：经营者个人银行卡
        /// <para>示例值：ACCOUNT_TYPE_BUSINESS</para>
        /// </remarks>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        /// <remarks>
        /// 返回特约商户的结算账户-开户银行全称。
        /// <para>示例值：工商银行</para>
        /// </remarks>
        [JsonPropertyName("account_bank")]
        public string AccountBank { get; set; }

        /// <summary>
        /// 开户银行全称（含支行）
        /// </summary>
        /// <remarks>
        /// 返回特约商户的结算账户-开户银行全称（含支行）。
        /// <para>示例值：施秉县农村信用合作联社城关信用社</para>
        /// </remarks>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 开户银行联行号
        /// </summary>
        /// <remarks>
        /// 返回特约商户的结算账户-联行号。
        /// <para>示例值：402713354941</para>
        /// </remarks>
        [JsonPropertyName("bank_branch_id")]
        public string BankBranchId { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        /// <remarks>
        /// 返回特约商户的结算账户-银行账号，掩码显示。
        /// <para>示例值：62*************78</para>
        /// </remarks>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 汇款验证结果
        /// </summary>
        /// <remarks>
        /// 返回特约商户的结算账户-汇款验证结果。
        /// VERIFYING：系统汇款验证中，商户可发起提现尝试。
        /// VERIFY_SUCCESS：系统成功汇款，该账户可正常发起提现。
        /// VERIFY_FAIL：系统汇款失败，该账户无法发起提现，请检查修改。
        /// <para>示例值：VERIFY_SUCCESS</para>
        /// </remarks>
        [JsonPropertyName("verify_result")]
        public string VerifyResult { get; set; }
    }
}
