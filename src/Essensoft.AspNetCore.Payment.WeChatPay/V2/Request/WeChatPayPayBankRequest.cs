using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 企业付款到银行卡 (普通商户)
    /// </summary>
    public class WeChatPayPayBankRequest : IWeChatPayCertRequest<WeChatPayPayBankResponse>
    {
        /// <summary>
        /// 商户企业付款单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 收款方银行卡号
        /// </summary>
        public string BankNo { get; set; }

        /// <summary>
        /// 收款方用户名
        /// </summary>
        public string TrueName { get; set; }

        /// <summary>
        /// 收款方开户行
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 付款备注
        /// </summary>
        public string Desc { get; set; }

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaysptrans/pay_bank";

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
                { "partner_trade_no", PartnerTradeNo},
                { "bank_code", BankCode },
                { "amount", Amount },
                { "desc", Desc}
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            if (string.IsNullOrEmpty(options.RsaPublicKey))
            {
                throw new WeChatPayException($"{nameof(WeChatPayPayBankRequest)}.{nameof(PrimaryHandler)}: {nameof(options.RsaPublicKey)} is null or empty!");
            }

            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.enc_bank_no, OaepSHA1WithRSA.Encrypt(BankNo, options.RsaPublicKey));
            sortedTxtParams.Add(WeChatPayConsts.enc_true_name, OaepSHA1WithRSA.Encrypt(TrueName, options.RsaPublicKey));

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
