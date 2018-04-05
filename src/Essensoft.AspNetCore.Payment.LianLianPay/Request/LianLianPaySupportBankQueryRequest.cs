using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPaySupportBankQueryRequest : ILianLianPayRequest<LianLianPaySupportBankQueryResponse>
    {
        /// <summary>
        /// 银行编码
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 银行卡类型
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// 支付渠道类型 
        /// 10 手机 SDK 
        /// 13 PC 端 WEB
        /// 15 API 支付接口
        /// 16 手机 WAP
        /// 见附录-支付渠道类型
        /// </summary>
        public string PayChnl { get; set; }

        #region ILianLianPayRequest
        private string ApiVersion = "1.0";

        public string GetRequestUrl()
        {
            return "https://queryapi.lianlianpay.com/supportbankquery.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "bank_code", BankCode },
                { "card_type", CardType },
                { "product_type", ProductType },
                { "pay_chnl", PayChnl },
                { "api_version", ApiVersion },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }
        #endregion
    }
}
