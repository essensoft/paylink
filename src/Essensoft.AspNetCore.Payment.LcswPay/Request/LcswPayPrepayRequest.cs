using Essensoft.AspNetCore.Payment.LcswPay.Response;
using Essensoft.AspNetCore.Payment.LcswPay.Utility;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LcswPay.Request
{
    /// <summary>
    /// 利楚商务扫员支付扫码支付请求
    /// </summary>
    public class LcswPayPrepayRequest : ILcswPayResquest<LcswPayPrepayResponse>
    {
        /// <summary>
        /// 请求类型，010微信，020 支付宝，060qq钱包，080京东钱包，090口碑，100翼支付
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }
        /// <summary>
        /// 接口类型，当前类型011
        /// </summary>
        [JsonProperty("service_id")]
        public string ServiceId { get; set; }
        /// <summary>
        /// 终端流水号，填写商户系统的订单号
        /// </summary>
        [JsonProperty("terminal_trace")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端交易时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [JsonProperty("terminal_time")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 金额，单位分
        /// </summary>
        [JsonProperty("total_fee")]
        public string TotalFee { get; set; }
        /// <summary>
        /// 公众号appid
        /// </summary>
        [JsonProperty("sub_appid")]
        public string SubAppid { get; set; }
        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonProperty("order_body")]
        public string OrderBody { get; set; }
        /// <summary>
        /// 外部系统通知地址
        /// </summary>
        [JsonProperty("notify_url")]
        public string NotifyUrl { get; set; }
        /// <summary>
        /// 附加数据，原样返回
        /// </summary>
        [JsonProperty("attach")]
        public string Attach { get; set; }
        /// <summary>
        /// 订单包含的商品列表信息，Json格式。pay_type为090时，可选填此字段
        /// </summary>
        [JsonProperty("goods_detail")]
        public string GoodsDetail { get; set; }

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
            return "/pay/100/prepay";
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
                    new LcswPayParaInfo("total_fee",TotalFee),
                    new LcswPayParaInfo("sub_appid",SubAppid,false),
                    new LcswPayParaInfo("order_body",OrderBody,false),
                    new LcswPayParaInfo("notify_url",NotifyUrl,false),
                    new LcswPayParaInfo("attach",Attach,false),
                    new LcswPayParaInfo("goods_detail",GoodsDetail,false)
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
