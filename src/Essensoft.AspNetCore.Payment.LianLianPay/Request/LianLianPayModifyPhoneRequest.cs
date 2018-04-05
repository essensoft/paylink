using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayModifyPhoneRequest : ILianLianPayRequest<LianLianPayModifyPhoneResponse>
    {
        /// <summary>
        /// 平台来源
        /// 平台来源能有效区分该交易是从此平台发起，并能有效定义用户来源。
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 用户唯一编号
        /// 商户用户唯一编号 保证唯一
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 协议号
        /// 签约协议号 协议号和银行卡号选择一个填写
        /// </summary>
        public string NoAgree { get; set; }

        /// <summary>
        /// 支付方式
        /// 2：快捷支付（借记卡）
        /// 3：快捷支付（信用卡）
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 银行卡号
        /// 协议号和银行卡号选择一个填写
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 新手机号
        /// </summary>
        public string BindMob { get; set; }

        #region ILianLianPayRequest
        public string GetRequestUrl()
        {
            return "https://traderapi.lianlianpay.com/modifyphone.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "platform", Platform },
                { "user_id", UserId },
                { "no_agree", NoAgree },
                { "pay_type", PayType },
                { "card_no", CardNo },
                { "bind_mob", BindMob },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return string.Empty;
        }

        public void SetApiVersion(string apiVersion)
        {
        }
        #endregion
    }
}
