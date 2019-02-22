using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LcswPay.Utility;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LcswPay.Response
{
    /// <summary>
    /// 1.1. 注册终端（获取access_token）响应信息
    /// </summary>
    public class LcswPaySignResponse:LcswPayResponse
    {
        /// <summary>
        /// 业务结果，01成功，表示注册成功；02失败，表示注册失败；
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("merchant_no")]
        public string MerchantNo { get; set; }
        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }
        /// <summary>
        /// 终端流水号，商户系统的订单号，扫呗系统原样返回
        /// </summary>
        [JsonProperty("terminal_trace")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端注册时间，yyyyMMddHHmmss，全局统一时间格式，例如：20161024101224
        /// </summary>
        [JsonProperty("terminal_time")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 令牌
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 是否业务结果为成功
        /// </summary>
        public bool IsResultCodeSuccess => ResultCode == "01";


        public override void AddSignedParasWhenReturnCodeSuccess(List<LcswPayParaInfo> signedParas)
        {
            signedParas.AddRange(new List<LcswPayParaInfo> {
                new LcswPayParaInfo("result_code", ResultCode),
                    new LcswPayParaInfo("merchant_no", MerchantNo),
                    new LcswPayParaInfo("terminal_id", TerminalId),
                    new LcswPayParaInfo("terminal_trace", TerminalTrace),
                    new LcswPayParaInfo("terminal_time", TerminalTime),
                    new LcswPayParaInfo("access_token", AccessToken)
            });
        }
    }
}
