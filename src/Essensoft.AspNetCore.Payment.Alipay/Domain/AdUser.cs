using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdUser Data Structure.
    /// </summary>
    [Serializable]
    public class AdUser : AlipayObject
    {
        /// <summary>
        /// 广告主营业执照url
        /// </summary>
        [JsonProperty("company_license")]
        public string CompanyLicense { get; set; }

        /// <summary>
        /// 广告主所属公司
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司行业信息
        /// </summary>
        [JsonProperty("company_trade")]
        public string CompanyTrade { get; set; }

        /// <summary>
        /// 1级行业ID
        /// </summary>
        [JsonProperty("first_trade_id")]
        public string FirstTradeId { get; set; }

        /// <summary>
        /// ICP营业执照编码
        /// </summary>
        [JsonProperty("icp_license")]
        public string IcpLicense { get; set; }

        /// <summary>
        /// 营业执照图片url
        /// </summary>
        [JsonProperty("icp_license_url")]
        public string IcpLicenseUrl { get; set; }

        /// <summary>
        /// 广告主公司地址
        /// </summary>
        [JsonProperty("register_place")]
        public string RegisterPlace { get; set; }

        /// <summary>
        /// 2级行业ID
        /// </summary>
        [JsonProperty("second_trade_id")]
        public string SecondTradeId { get; set; }

        /// <summary>
        /// 广告主电话
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 第三方平台用户ID
        /// </summary>
        [JsonProperty("third_user_id")]
        public string ThirdUserId { get; set; }

        /// <summary>
        /// 广告主邮箱
        /// </summary>
        [JsonProperty("user_mail")]
        public string UserMail { get; set; }

        /// <summary>
        /// 广告系统用户
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
