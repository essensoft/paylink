using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 商户进件（普通服务商）- 修改结算帐号API - 请求JSON参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_3.shtml">商户进件（普通服务商）- 修改结算帐号API</a></para>
    /// 最新更新时间：2019.09.09
    /// </summary>
    public class WeChatPayApply4SubSubMerchantsSubMchIdModifySettlementBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 账户类型
        /// 根据特约商户号的主体类型，可选择的账户类型如下：
        /// 1、小微主体：经营者个人银行卡
        /// 2、个体工商户主体：经营者个人银行卡/ 对公银行账户
        /// 3、企业主体：对公银行账户
        /// 4、党政、机关及事业单位主体：对公银行账户
        /// 5、其他组织主体：对公银行账户
        /// 枚举值：
        /// ACCOUNT_TYPE_BUSINESS：对公银行账户
        /// ACCOUNT_TYPE_PRIVATE：经营者个人银行卡
        /// 示例值：ACCOUNT_TYPE_BUSINESS
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 开户银行
        /// 请填写开户银行名称，详细参见《开户银行对照表》。
        /// 示例值：工商银行
        /// </summary>
        [JsonPropertyName("account_bank")]
        public string AccountBank { get; set; }

        /// <summary>
        /// 开户银行省市编码
        /// 需至少精确到市，详细参见《省市区编号对照表》。
        /// 示例值：110000
        /// </summary>
        [JsonPropertyName("bank_address_code")]
        public string BankAddressCode { get; set; }

        /// <summary>
        /// 开户银行全称（含支行）
        /// 若开户银行为“其他银行”，则需二选一填写“开户银行全称（含支行）”或“开户银行联行号”。
        /// 填写银行全称，如"深圳农村商业银行XXX支行" ，详细参见开户银行全称（含支行）对照表。
        /// 示例值：施秉县农村信用合作联社城关信用社
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 开户银行联行号
        /// 若开户银行为“其他银行”，则需二选一填写“开户银行全称（含支行）”或“开户银行联行号”。
        /// 填写银行联行号，详细参见《开户银行全称（含支行）对照表》。
        /// 示例值：402713354941
        /// </summary>
        [JsonPropertyName("bank_branch_id")]
        public string BankBranchId { get; set; }

        /// <summary>
        /// 银行账号
        /// 1、数字，长度遵循系统支持的对公/对私卡号长度要求
        /// 2、该字段需进行加密处理，加密方法详见《敏感信息加密说明》。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// 示例值：d+xT+MQCvrLHUVDWv/8MR/dB7TkXM2YYZlokmXzFsWs35NXUot7C0NcxIrUF5FnxqCJHkNgKtxa6RxEYyba1+VBRLnqKG2fSy/Y5qDN08Ej9zHCwJjq52Wg1VG8MRugli9YMI1fI83KGBxhuXyemgS/hqFKsfYGiOkJqjTUpgY5VqjtL2N4l4z11T0ECB/aSyVXUysOFGLVfSrUxMPZy6jWWYGvT1+4P633f+R+ki1gT4WF/2KxZOYmli385ZgVhcR30mr4/G3HBcxi13zp7FnEeOsLlvBmI1PHN4C7Rsu3WL8sPndjXTd75kPkyjqnoMRrEEaYQE8ZRGYoeorwC+w==
        /// </summary>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }
    }
}
