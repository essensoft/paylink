using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayQueryBankCarBindListRequest : ILianLianPayRequest<LianLianPayQueryBankCarBindListResponse>
    {
        /// <summary>
        /// 商户用户唯一编号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 平台来源标示
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 签约协议号
        /// </summary>
        public string NoAgree { get; set; }

        /// <summary>
        /// 签约银行卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 查询偏移量
        /// </summary>
        public string Offset { get; set; }

        #region ILianLianPayRequest

        public string GetRequestUrl()
        {
            return "https://queryapi.lianlianpay.com/bankcardbindlist.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "user_id", UserId },
                { "platform", Platform },
                { "pay_type", PayType },
                { "no_agree", NoAgree },
                { "card_no", CardNo },
                { "offset", Offset }
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
