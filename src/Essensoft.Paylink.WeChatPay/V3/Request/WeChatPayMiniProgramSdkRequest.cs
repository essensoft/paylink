using System.Collections.Generic;
using Essensoft.Paylink.Security;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 小程序支付 - 小程序调起支付
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_4.shtml">小程序支付 - 小程序调起支付API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayMiniProgramSdkRequest : IWeChatPaySdkRequest
    {
        /// <summary>
        /// 订单详情扩展字符串
        /// </summary>
        /// <remarks>
        /// 统一下单接口返回的prepay_id参数值，提交格式如：prepay_id=***
        /// <para>示例值：prepay_id=wx201410272009395522657a690389285100\</para>
        /// </remarks>
        public string Package { get; set; }

        #region IWeChatPaySdkRequest Members

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "package", Package }
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            if (!string.IsNullOrEmpty(options.SubAppId))
            {
                sortedTxtParams.Add(WeChatPayConsts.appId, options.SubAppId);
            }
            else
            {
                sortedTxtParams.Add(WeChatPayConsts.appId, options.AppId);
            }

            sortedTxtParams.Add(WeChatPayConsts.timeStamp, WeChatPayUtility.GetTimeStamp());
            sortedTxtParams.Add(WeChatPayConsts.nonceStr, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.signType, WeChatPayConsts.RSA);

            var signatureSourceData = BuildSignatureSourceData(sortedTxtParams);
            sortedTxtParams.Add(WeChatPayConsts.paySign, SHA256WithRSA.Sign(options.CertificateRSAPrivateKey, signatureSourceData));
        }

        private static string BuildSignatureSourceData(WeChatPayDictionary sortedTxtParams)
        {
            return $"{sortedTxtParams.GetValue(WeChatPayConsts.appId)}\n{sortedTxtParams.GetValue(WeChatPayConsts.timeStamp)}\n{sortedTxtParams.GetValue(WeChatPayConsts.nonceStr)}\n{sortedTxtParams.GetValue(WeChatPayConsts.package)}\n";
        }

        #endregion
    }
}
