using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 微信代扣 - 车主平台 - 用户状态查询 (服务商)
    /// </summary>
    public class WeChatPayVehiclePartnerPayQueryStateRequest : IWeChatPayRequest<WeChatPayVehiclePartnerPayQueryStateResponse>
    {
        /// <summary>
        /// 交易场景
        /// </summary>
        public string TradeScene { get; set; }

        /// <summary>
        /// 跳转场景
        /// </summary>
        public string JumpScene { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 用户子标识
        /// </summary>
        public string SubOpenId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string PlateNumber { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/vehicle/partnerpay/querystate";

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
                { "trade_scene", TradeScene },
                { "jump_scene", JumpScene },
                { "openid", OpenId },
                { "sub_openid", SubOpenId },
                { "plate_number", PlateNumber },
                { "version", Version },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.HMAC_SHA256;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
