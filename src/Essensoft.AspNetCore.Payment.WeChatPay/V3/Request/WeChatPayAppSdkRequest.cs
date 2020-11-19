using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// APP支付 调起支付
    /// 最新更新时间：2020.09.29
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_8.shtml
    /// </summary>
    public class WeChatPayAppSdkRequest : IWeChatPaySdkRequest
    {
        /// <summary>
        /// 预支付交易会话ID
        /// 微信返回的支付交易会话id。
        /// 示例值： WX1217752501201407033233368018
        /// </summary>
        public string PrepayId { get; set; }

        /// <summary>
        /// 订单详情扩展字符串
        /// 暂填写固定值Sign=WXPay
        /// 示例值：Sign=WXPay
        /// </summary>
        public string Package { get; set; } = "Sign=WXPay";

        #region IWeChatPaySdkRequest Members

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "prepayid", PrepayId },
                { "package", Package }
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPayDictionary sortedTxtParams)
        {
            if (!string.IsNullOrEmpty(options.SubAppId) && !string.IsNullOrEmpty(options.SubMchId))
            {
                sortedTxtParams.Add(WeChatPayConsts.appid, options.SubAppId);
                sortedTxtParams.Add(WeChatPayConsts.partnerid, options.SubMchId);
            }
            else
            {
                sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
                sortedTxtParams.Add(WeChatPayConsts.partnerid, options.MchId);
            }

            sortedTxtParams.Add(WeChatPayConsts.noncestr, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.timestamp, WeChatPayUtility.GetTimeStamp());

            var signatureSourceData = BuildSignatureSourceData(sortedTxtParams);
            sortedTxtParams.Add(WeChatPayConsts.paySign, SHA256WithRSA.Sign(options.CertificateRSAPrivateKey, signatureSourceData));
        }

        private static string BuildSignatureSourceData(WeChatPayDictionary sortedTxtParams)
        {
            return $"{sortedTxtParams.GetValue(WeChatPayConsts.appid)}\n{sortedTxtParams.GetValue(WeChatPayConsts.timestamp)}\n{sortedTxtParams.GetValue(WeChatPayConsts.noncestr)}\n{sortedTxtParams.GetValue(WeChatPayConsts.prepayid)}\n";
        }

        #endregion
    }
}
