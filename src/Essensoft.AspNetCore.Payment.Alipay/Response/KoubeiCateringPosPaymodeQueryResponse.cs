using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosPaymodeQueryResponse.
    /// </summary>
    public class KoubeiCateringPosPaymodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付方式列表
        /// </summary>
        [JsonPropertyName("pay_mode_model_list")]
        public List<PayModeModel> PayModeModelList { get; set; }
    }
}
