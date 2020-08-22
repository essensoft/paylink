using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 交易保障 (普通商户 / 服务商)
    /// </summary>
    public class WeChatPayPayitilReportRequest : IWeChatPayRequest<WeChatPayPayitilReportResponse>
    {
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

        private string requestUrl = "https://api.mch.weixin.qq.com/payitil/report";

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
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
                { "time", Time }
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
