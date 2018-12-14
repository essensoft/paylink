using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 查询企业付款
    /// </summary>
    public class WeChatPayGetTransferInfoRequest : WeChatPayCertificateRequest<WeChatPayGetTransferInfoResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        #region IWeChatPayCertificateRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/gettransferinfo";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_partner_trade_no, PartnerTradeNo }
            };
            return parameters;
        }
        public override void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options)
        {
        }

        protected override void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            base.HandleParametersInOptions(sortedTxtParams, options);

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_appid)))
            {
                sortedTxtParams.Add(ConstKey.Key_appid, options.AppId);
            }

            sortedTxtParams.Add(ConstKey.Key_mch_id, options.MchId);
            sortedTxtParams.Add(ConstKey.Key_sign_type, ConstKey.Key_MD5);

        }
        #endregion
    }
}
