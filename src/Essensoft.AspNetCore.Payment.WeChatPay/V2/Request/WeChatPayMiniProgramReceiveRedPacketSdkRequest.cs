using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 小程序红包 - 领取红包
    /// </summary>
    public class WeChatPayMiniProgramReceiveRedPacketSdkRequest : IWeChatPaySdkRequest
    {
        /// <summary>
        /// 红包详情的扩展
        /// </summary>
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

        public void PrimaryHandler(WeChatPayOptions options, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.timeStamp, WeChatPayUtility.GetTimeStamp());
            sortedTxtParams.Add(WeChatPayConsts.nonceStr, WeChatPayUtility.GenerateNonceStr());

            sortedTxtParams.Add(WeChatPayConsts.signType, WeChatPayConsts.MD5);
            sortedTxtParams.Add(WeChatPayConsts.paySign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, WeChatPaySignType.MD5));
        }

        #endregion
    }
}
