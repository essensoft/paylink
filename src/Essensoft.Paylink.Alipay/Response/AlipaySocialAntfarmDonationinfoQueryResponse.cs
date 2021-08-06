using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntfarmDonationinfoQueryResponse.
    /// </summary>
    public class AlipaySocialAntfarmDonationinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前用户捐赠爱心记录
        /// </summary>
        [JsonPropertyName("donation_list")]
        public List<AntfarmUserDonationInfo> DonationList { get; set; }
    }
}
