using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 支持银行查询
    /// </summary>
    public class LianLianPaySupportBankQueryRequest : ILianLianPayRequest<LianLianPaySupportBankQueryResponse>
    {
        /// <summary>
        /// 银行编码。
        /// 可调用卡bin查询API进行查询。
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 银行卡类型，默认且目前仅支持2。
        /// 2 - 借记卡。
        /// 3 - 信用卡。
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// 产品类型。
        /// 1 - 普通认证收款或分期收款。
        /// 3 - 新认证收款。
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// 收款产品所配置的来源标识。
        /// 10 - 认证收款APP。
        /// 13 - 认证收款PC端网页。
        /// 15 - 认证收款API。
        /// 16 - 认证收款移动端网页。
        /// 44 - 分期收款API。
        /// 45 - 分期收款APP。
        /// 46 - 分期收款移动端网页。
        /// 55 - 分期收款PC端网页。
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
                { "api_version", ApiVersion },
                { "bank_code", BankCode },
                { "card_type", CardType },
                { "product_type", ProductType },
                { "pay_chnl", PayChnl }
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
