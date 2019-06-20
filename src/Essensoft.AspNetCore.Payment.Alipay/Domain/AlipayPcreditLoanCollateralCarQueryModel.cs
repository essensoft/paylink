using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanCollateralCarQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanCollateralCarQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，即用户授信申请的单号，每次授信申请由借呗平台生成的唯一编号，通知估值时给到机构
        /// </summary>
        [JsonProperty("apply_no")]
        public string ApplyNo { get; set; }
    }
}
