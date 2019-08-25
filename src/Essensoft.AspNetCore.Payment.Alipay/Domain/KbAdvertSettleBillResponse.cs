using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertSettleBillResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertSettleBillResponse : AlipayObject
    {
        /// <summary>
        /// 账单下载地址(为空表示查无账单)
        /// </summary>
        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 结算账单打款日期(为空表示未打款)
        /// </summary>
        [JsonProperty("paid_date")]
        public string PaidDate { get; set; }
    }
}
