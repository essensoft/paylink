using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanApplyUserCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanApplyUserCertifyModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，即用户授信申请的单号，每次授信申请由借呗平台生成的唯一编号，通知估值时给到机构
        /// </summary>
        [JsonProperty("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 证件号码，当前只支持身份证号码，验证授信申请的用户证件号
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，和证件号cert_no配合使用，由平台定义，目前支持的证件类型有：  IDENTITY_CARD-身份证
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户姓名，需要验证的授信申请人姓名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
