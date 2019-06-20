using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SupplierVO Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierVO : AlipayObject
    {
        /// <summary>
        /// 生效状态，EFFECTIVE：生效，INVALID：失效。
        /// </summary>
        [JsonProperty("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 快餐
        /// </summary>
        [JsonProperty("business_desc")]
        public string BusinessDesc { get; set; }

        /// <summary>
        /// 供应商附加信息，LICENSE_NO:许可证号,LICENSE_DATE:营业执照有效期,PAYMENT_DAYS:账期
        /// </summary>
        [JsonProperty("certificate_desc")]
        public string CertificateDesc { get; set; }

        /// <summary>
        /// 供货商简码
        /// </summary>
        [JsonProperty("short_code")]
        public string ShortCode { get; set; }

        /// <summary>
        /// 供货商ID
        /// </summary>
        [JsonProperty("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 张三
        /// </summary>
        [JsonProperty("supplier_name")]
        public string SupplierName { get; set; }
    }
}
