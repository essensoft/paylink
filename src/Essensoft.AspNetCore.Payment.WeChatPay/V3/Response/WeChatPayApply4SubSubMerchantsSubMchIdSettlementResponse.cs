using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 商户进件 - 查询结算账户API（普通服务商）- 返回参数
    /// 最新更新时间：2019.09.09
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_4.shtml
    /// </summary>
    public class WeChatPayApply4SubSubMerchantsSubMchIdSettlementResponse : WeChatPayResponse
    {
        /// <summary>
        /// 账户类型
        /// 返回特约商户的结算账户类型。
        /// 枚举值：
        /// ACCOUNT_TYPE_BUSINESS：对公银行账户
        /// ACCOUNT_TYPE_PRIVATE：经营者个人银行卡
        /// 示例值：ACCOUNT_TYPE_BUSINESS
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 开户银行
        /// 返回特约商户的结算账户-开户银行全称。
        /// 示例值：工商银行
        /// </summary>
        [JsonPropertyName("account_bank")]
        public string AccountBank { get; set; }

        /// <summary>
        /// 开户银行全称（含支行）
        /// 返回特约商户的结算账户-开户银行全称（含支行）。
        /// 示例值：施秉县农村信用合作联社城关信用社
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 开户银行联行号
        /// 返回特约商户的结算账户-联行号。
        /// 示例值：402713354941
        /// </summary>
        [JsonPropertyName("bank_branch_id")]
        public string BankBranchId { get; set; }

        /// <summary>
        /// 银行账号
        /// 返回特约商户的结算账户-银行账号，掩码显示。
        /// 示例值：62*************78
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 汇款验证结果
        /// 返回特约商户的结算账户-汇款验证结果。
        /// VERIFYING：系统汇款验证中，商户可发起提现尝试。
        /// VERIFY_SUCCESS：系统成功汇款，该账户可正常发起提现。
        /// VERIFY_FAIL：系统汇款失败，该账户无法发起提现，请检查修改。
        /// 示例值：VERIFY_SUCCESS
        /// </summary>
        [JsonPropertyName("verify_result")]
        public string VerifyResult { get; set; }
    }
}
