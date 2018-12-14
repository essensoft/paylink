using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 企业付款到银行卡
    /// </summary>
    public class WeChatPayPayBankRequest : WeChatPayCertificateRequest<WeChatPayPayBankResponse>
    {
        /// <summary>
        /// 商户企业付款单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 收款方银行卡号
        /// </summary>
        public string EncBankNo { get; set; }

        /// <summary>
        /// 收款方用户名
        /// </summary>
        public string EncTrueName { get; set; }

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

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaysptrans/pay_bank";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_partner_trade_no, PartnerTradeNo},
                { ConstKey.Key_enc_bank_no, EncBankNo },
                { ConstKey.Key_enc_true_name, EncTrueName },
                { ConstKey.Key_bank_code, BankCode },
                { ConstKey.Key_amount, Amount },
                { ConstKey.Key_desc, Desc}
            };
            return parameters;
        }

        protected override void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            if (options.PublicKey == null)
            {
                throw new WeChatPayException("WeChatPayPayBankRequest: PublicKey is null!");
            }

            base.HandleParametersInOptions(sortedTxtParams, options);

            var no = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Encrypt(sortedTxtParams.GetValue(ConstKey.Key_enc_bank_no), options.PublicKey);
            sortedTxtParams.SetValue(ConstKey.Key_enc_bank_no, no);

            var name = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Encrypt(sortedTxtParams.GetValue(ConstKey.Key_enc_true_name), options.PublicKey);
            sortedTxtParams.SetValue(ConstKey.Key_enc_true_name, name);

            sortedTxtParams.Add(ConstKey.Key_mch_id, options.MchId);
            sortedTxtParams.Add(ConstKey.Key_sign_type, ConstKey.Key_MD5);
        }
        #endregion
    }
}
