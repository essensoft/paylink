using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 交易保障
    /// </summary>
    public class WeChatPayReportRequest : WechatPayRequest<WeChatPayReportResponse>
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

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/payitil/report";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_sub_appid, SubAppId },
                { ConstKey.Key_sub_mch_id, SubMchId },
                { ConstKey.Key_device_info, DeviceInfo },
                { ConstKey.Key_interface_url, InterfaceUrl },
                { ConstKey.Key_execute_time, ExecuteTime },
                { ConstKey.Key_return_code, ReturnCode },
                { ConstKey.Key_return_msg, ReturnMsg },
                { ConstKey.Key_result_code, ResultCode },
                { ConstKey.Key_err_code, ErrCode },
                { ConstKey.Key_err_code_des, ErrCodeDes },
                { ConstKey.Key_out_trade_no, OutTradeNo },
                { ConstKey.Key_user_ip, UserIp },
                { ConstKey.Key_time, Time }
            };
            return parameters;
        }
        public override void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options)
        {
        }

        #endregion
    }
}
