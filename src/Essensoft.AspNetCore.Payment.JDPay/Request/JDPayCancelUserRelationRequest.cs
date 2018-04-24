using Essensoft.AspNetCore.Payment.JDPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.JDPay.Request
{
    /// <summary>
    /// 用户关系解绑接口
    /// </summary>
    public class JDPayCancelUserRelationRequest : IJDPayRequest<JDPayCancelUserRelationResponse>
    {
        /// <summary>
        /// 商户用户标识
        /// </summary>
        public string UserId { get; set; }

        #region IJDPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://paygate.jd.com/service/cancelUserRelation";
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new JDPayDictionary()
            {
                { "userId", UserId },
            };
            return parameters;
        }

        #endregion
    }
}
