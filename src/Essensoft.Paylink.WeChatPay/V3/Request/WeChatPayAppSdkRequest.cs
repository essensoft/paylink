using System.Collections.Generic;
using Essensoft.Paylink.Security;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - APP支付 - APP调起支付
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_4.shtml">APP支付 - APP调起支付API</a> - 最新更新时间：2020.09.29</para>
    /// </remarks>
    public class WeChatPayAppSdkRequest : IWeChatPaySdkRequest
    {
        /// <summary>
        /// 预支付交易会话ID
        /// </summary>
        /// <remarks>
        /// 微信返回的支付交易会话id。
        /// <para>示例值：WX1217752501201407033233368018</para>
        /// </remarks>
        public string PrepayId { get; set; }

        /// <summary>
        /// 订单详情扩展字符串
        /// </summary>
        /// <remarks>
        /// 暂填写固定值Sign=WXPay
        /// <para>示例值：Sign=WXPay</para>
        /// </remarks>
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

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
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
            sortedTxtParams.Add(WeChatPayConsts.sign, SHA256WithRSA.Sign(options.CertificateRSAPrivateKey, signatureSourceData));
        }

        private static string BuildSignatureSourceData(WeChatPayDictionary sortedTxtParams)
        {
            return $"{sortedTxtParams.GetValue(WeChatPayConsts.appid)}\n{sortedTxtParams.GetValue(WeChatPayConsts.timestamp)}\n{sortedTxtParams.GetValue(WeChatPayConsts.noncestr)}\n{sortedTxtParams.GetValue(WeChatPayConsts.prepayid)}\n";
        }

        #endregion
    }
}
