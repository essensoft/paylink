using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTaxUserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTaxUserinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号标识号,由identify_account_type指定类型:  identify_account_type为barcode表示支付宝钱包付款码,退税公司通过扫描用户支付宝钱包付款码获取,17位到32位的数字.  identify_account_type为logonId表示支付宝钱包登录号,需用户自己提供.
        /// </summary>
        [JsonProperty("identify_account_no")]
        public string IdentifyAccountNo { get; set; }

        /// <summary>
        /// 支付宝账号标识类型，  条码退税,取值:barcode  登录号退税,取值:logonId
        /// </summary>
        [JsonProperty("identify_account_type")]
        public string IdentifyAccountType { get; set; }
    }
}
