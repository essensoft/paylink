using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 交易保障
    /// </summary>
    public class WeChatPayReportRequest : IWeChatPayRequest<WeChatPayReportResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 接口URL
        /// </summary>
        public string InterfaceUrl { get; set; }

        /// <summary>
        /// 接口耗时
        /// </summary>
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 返回状态码
        /// </summary>
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误代码描述
        /// </summary>
        public string ErrCodeDes { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 访问接口IP
        /// </summary>
        public string UserIp { get; set; }

        /// <summary>
        /// 商户上报时间
        /// </summary>
        public string Time { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/payitil/report";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "appid", AppId },
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "device_info", DeviceInfo },
                { "interface_url", InterfaceUrl },
                { "execute_time", ExecuteTime },
                { "return_code", ReturnCode },
                { "return_msg", ReturnMsg },
                { "result_code", ResultCode },
                { "err_code", ErrCode },
                { "err_code_des", ErrCodeDes },
                { "out_trade_no", OutTradeNo },
                { "user_ip", UserIp },
                { "time", Time },
            };
            return parameters;
        }

        #endregion
    }
}
