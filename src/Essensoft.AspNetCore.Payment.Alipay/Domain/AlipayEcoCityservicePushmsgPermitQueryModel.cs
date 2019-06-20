using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityservicePushmsgPermitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityservicePushmsgPermitQueryModel : AlipayObject
    {
        /// <summary>
        /// 证件号码  证件号码. 证件号码,手机号,姓名三个参 数至少有一个非空,多个条件的 情况下,按照身份证号,手机号 ,姓名的顺序匹配
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型   证件号码非空时,此字段必填  IDENTITY_CARD:身份证  PASSPORT:护照  OFFICER_CARD:军官证  SOLDIER_CARD:士兵证  BACK_HOMETOWN_CARD:回乡证  TEMP_INDENTITY_CARD:临时身份证  HOKOU:户口簿  POLICE_CARD:警官证  TAIWAN_CARD:台胞证  BUSINESS_LICENSE:营业执照  TW_HK_MC_LICENSE:港澳台居民大陆通行证
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 手机号码   证件号码,手机号,姓名三个参 数至少有一个非空,多个条件的 情况下,按照身份证号,手机号 ,姓名的顺序匹配
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 个人用户姓名   证件号码,手机号,姓名三个参 数至少有一个非空,多个条件的 情况下,按照身份证号,手机号 ,姓名的顺序匹配
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
