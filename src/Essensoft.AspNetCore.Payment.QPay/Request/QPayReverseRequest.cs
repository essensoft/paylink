using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;
using Essensoft.AspNetCore.Payment.QPay.Utility;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 撤销订单 (普通商户 / 服务商)
    /// </summary>
    public class QPayReverseRequest : IQPayCertRequest<QPayReverseResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 操作员密码的MD5
        /// </summary>
        public string OpUserPasswd { get; set; }

        #region IQPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.qpay.qq.com/cgi-bin/pay/qpay_reverse.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "out_trade_no", OutTradeNo },
                { "op_user_id", OpUserId },
                { "op_user_passwd", OpUserPasswd }
            };
            return parameters;
        }

        public void PrimaryHandler(QPayOptions options, QPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(QPayConsts.NONCE_STR, QPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(QPayConsts.APPID, options.AppId);
            sortedTxtParams.Add(QPayConsts.SUB_APPID, options.SubAppId);
            sortedTxtParams.Add(QPayConsts.MCH_ID, options.MchId);
            sortedTxtParams.Add(QPayConsts.SUB_MCH_ID, options.SubMchId);

            sortedTxtParams.Add(QPayConsts.SIGN, QPaySignature.SignWithKey(sortedTxtParams, options.Key));
        }

        public bool GetNeedCheckSign()
        {
            return true;
        }

        #endregion
    }
}
