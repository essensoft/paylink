using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcardEduCardGetResponse.
    /// </summary>
    public class AlipayEcardEduCardGetResponse : AlipayResponse
    {
        /// <summary>
        /// 用户是否首次充值标记
        /// </summary>
        [JsonPropertyName("first_deposit_flag")]
        public bool FirstDepositFlag { get; set; }

        /// <summary>
        /// 校园一卡通历史充值卡信息查询结果对象
        /// </summary>
        [JsonPropertyName("onecard")]
        public List<EduOneCardDepositCardQueryResult> Onecard { get; set; }
    }
}
