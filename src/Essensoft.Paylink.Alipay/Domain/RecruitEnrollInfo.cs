using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RecruitEnrollInfo Data Structure.
    /// </summary>
    public class RecruitEnrollInfo : AlipayObject
    {
        /// <summary>
        /// 报名商户
        /// </summary>
        [JsonPropertyName("enroll_merchant")]
        public RecruitEnrollMerchant EnrollMerchant { get; set; }

        /// <summary>
        /// 报名需要提交的素材
        /// </summary>
        [JsonPropertyName("materials")]
        public List<RecruitMaterial> Materials { get; set; }

        /// <summary>
        /// 报名提交的小程序信息，是否必选取决于方案要求
        /// </summary>
        [JsonPropertyName("mini_apps")]
        public List<RecruitMiniApp> MiniApps { get; set; }

        /// <summary>
        /// 报名提交的券信息，是否必选取决于方案要求
        /// </summary>
        [JsonPropertyName("vouchers")]
        public List<RecruitVoucher> Vouchers { get; set; }
    }
}
