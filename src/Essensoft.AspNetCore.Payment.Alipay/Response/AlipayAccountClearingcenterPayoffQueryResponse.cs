using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffQueryResponse.
    /// </summary>
    public class AlipayAccountClearingcenterPayoffQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 待解付登记薄列表
        /// </summary>
        [JsonPropertyName("pay_off_order_list")]
        public List<PayOffOrderVO> PayOffOrderList { get; set; }

        /// <summary>
        /// EXECUTE_SUCCESS UNKNOWN_EXCEPTION DATABASE_EXCEPTION
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 处理成功 未知异常 数据库异常
        /// </summary>
        [JsonPropertyName("result_description")]
        public string ResultDescription { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
