using Essensoft.AspNetCore.Payment.LcswPay.Response;
using Essensoft.AspNetCore.Payment.LcswPay.Utility;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LcswPay.Request
{
    public class LcswPaySignRequest : ILcswPayResquest<LcswPaySignResponse>
    {
        /// <summary>
        /// 版本号，当前版本100
        /// </summary>
        public string PayVersion { get; set; }
        /// <summary>
        /// 接口类型，当前类型090
        /// </summary>
        public string ServiceId { get; set; }
        /// <summary>
        /// 扫呗商户号
        /// </summary>
        public string MerchantNo { get; set; }
        /// <summary>
        /// 扫呗终端号
        /// </summary>
        public string TerminalId { get; set; }
        /// <summary>
        /// 终端流水号，填写商户系统的订单号
        /// </summary>
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端注册时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        public string TerminalTime { get; set; }

        #region ILcswResquest

        /// <summary>
        /// 获取请求相关的签名信息
        /// 包含签名参数信息和签名计算方式
        /// </summary>
        /// <returns>签名信息</returns>
        public LcswPaySignInfo GetSignInfo()
        {
            return new LcswPaySignInfo
            {
                SignType = LcswPaySignType.AllRequiredPara,
                ParaInfos = new List<LcswPayParaInfo> {
                    new LcswPayParaInfo("pay_ver",PayVersion),
                    new LcswPayParaInfo("service_id",ServiceId),
                    new LcswPayParaInfo("merchant_no",MerchantNo),
                    new LcswPayParaInfo("terminal_id",TerminalId),
                    new LcswPayParaInfo("terminal_trace",TerminalTrace),
                    new LcswPayParaInfo("terminal_time",TerminalTime)
                }
            };
        }

        /// <summary>
        /// API接口地址,真实调用前，还需要在此地址的前面加上基准地址，构成完成的地址后进行请求
        /// </summary>
        /// <returns>API接口地址</returns>
        public string GetRequestUrl()
        {
            return "/pay/100/sign";
        }

        /// <summary>
        /// 是否验证响应内容签名
        /// </summary>
        /// <returns>是否验证</returns>
        public bool IsCheckResponseSign()
        {
            return true;
        } 
        #endregion
    }
}
