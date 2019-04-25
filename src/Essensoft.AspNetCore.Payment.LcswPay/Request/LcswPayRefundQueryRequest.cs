using Essensoft.AspNetCore.Payment.LcswPay.Response;
using Essensoft.AspNetCore.Payment.LcswPay.Utility;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LcswPay.Request
{
    /// <summary>
    /// 利楚商务扫呗支付退款查询请求
    /// </summary>
    public class LcswPayRefundQueryRequest : ILcswPayResquest<LcswPayRefundQueryResponse>
    {
        /// <summary>
        /// 请求类型，010微信，020 支付宝，060qq钱包，080京东钱包，090口碑，100翼支付，110银联二维码，000自动识别类型
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }
        /// <summary>
        /// 接口类型，当前类型031
        /// </summary>
        [JsonProperty("service_id")]
        public string ServiceId { get; set; }
        /// <summary>
        /// 当前终端退款查询流水号，填写商户系统的退款查询流水号
        /// </summary>
        [JsonProperty("terminal_trace")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 当前终端退款查询时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [JsonProperty("terminal_time")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 退款金额，单位分
        /// </summary>
        [JsonProperty("out_refund_no")]
        public string OutRefundNo { get; set; }
        /// <summary>
        /// 退款终端流水号，与pay_time同时传递
        /// </summary>
        [JsonProperty("pay_trace")]
        public string PayTrace { get; set; }
        /// <summary>
        /// 退款终端交易时间，yyyyMMddHHmmss，全局统一时间格式，与pay_trace同时传递
        /// </summary>
        [JsonProperty("pay_time")]
        public string PayTime { get; set; }

        #region ILcswPayResquest Members
        /// <summary>
        /// 版本号，当前版本100
        /// </summary>
        [JsonProperty("pay_ver")]
        public string PayVersion { get; set; }
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

        public string GetRequestUrl()
        {
            return "/pay/100/queryrefund";
        }

        public LcswPaySignInfo GetSignInfo()
        {
            return new LcswPaySignInfo
            {
                SignType = LcswPaySignType.AllRequiredParaAndToken,
                ParaInfos = new List<LcswPayParaInfo>
                {
                    new LcswPayParaInfo("pay_ver",PayVersion),
                    new LcswPayParaInfo("pay_type",PayType),
                    new LcswPayParaInfo("service_id",ServiceId),
                    new LcswPayParaInfo("merchant_no",MerchantNo),
                    new LcswPayParaInfo("terminal_id",TerminalId),
                    new LcswPayParaInfo("terminal_trace",TerminalTrace),
                    new LcswPayParaInfo("terminal_time",TerminalTime),
                    new LcswPayParaInfo("out_refund_no",OutRefundNo,false),
                    new LcswPayParaInfo("pay_trace",PayTrace,false),
                    new LcswPayParaInfo("pay_time",PayTime,false)
                }
            };
        }

        public bool IsCheckResponseSign()
        {
            return true;
        }
        #endregion
    }
}
