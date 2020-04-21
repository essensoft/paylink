using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTaxUserinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxUserinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号标识号,由identify_account_type指定类型:  identify_account_type为barcode表示支付宝钱包付款码,退税公司通过扫描用户支付宝钱包付款码获取,17位到32位的数字.  identify_account_type为logonId表示支付宝钱包登录号,需用户自己提供.
        /// </summary>
        [JsonPropertyName("identify_account_no")]
        public string IdentifyAccountNo { get; set; }

        /// <summary>
        /// 支付宝账号标识类型，  条码退税,取值:barcode  登录号退税,取值:logonId
        /// </summary>
        [JsonPropertyName("identify_account_type")]
        public string IdentifyAccountType { get; set; }
    }
}
