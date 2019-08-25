using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PreOrderResult Data Structure.
    /// </summary>
    [Serializable]
    public class PreOrderResult : AlipayObject
    {
        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 校验是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
