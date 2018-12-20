using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 企业付款 - 企业付款到余额
    /// </summary>
    public class QPayEPayB2CRequest : IQPayCertificateRequest<QPayEPayB2CResponse>
    {
        /// <summary>
        /// 字符集
        /// </summary>
        public string InputCharset { get; set; } = "UTF-8";

        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 用户opeind
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 收款QQ号码
        /// </summary>
        public string Uin { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public string TotalFee { get; set; }

        /// <summary>
        /// 付款备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 校验用户姓名
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// 收款用户姓名
        /// </summary>
        public string ReUserName { get; set; }

        /// <summary>
        /// 校验用户是否实名
        /// </summary>
        public string CheckRealName { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 操作员密码的MD5
        /// </summary>
        public string OpUserPasswd { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string SpbillCreateIp { get; set; }

        /// <summary>
        /// 用户到账结果通知
        /// </summary>
        public string NotifyUrl { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.qpay.qq.com/cgi-bin/epay/qpay_epay_b2c.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "input_charset", InputCharset },
                { "appid", AppId },
                { "openid", OpenId },
                { "uin", Uin },
                { "out_trade_no", OutTradeNo },
                { "fee_type", FeeType },
                { "total_fee", TotalFee },
                { "memo", Memo },
                { "check_name", CheckName },
                { "re_user_name", ReUserName },
                { "check_real_name", CheckRealName },
                { "op_user_id", OpUserId },
                { "op_user_passwd", OpUserPasswd },
                { "spbill_create_ip", SpbillCreateIp },
                { "notify_url", NotifyUrl },
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return false;
        }

        #endregion
    }
}
