using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;
using Essensoft.AspNetCore.Payment.QPay.Utility;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 现金红包 - 红包详情查询
    /// </summary>
    public class QPayHbMchListQueryRequest : IQPayRequest<QPayHbMchListQueryResponse>
    {
        /// <summary>
        /// 发起方式
        /// </summary>
        public long SendType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 红包单号
        /// </summary>
        public string ListId { get; set; }

        /// <summary>
        /// 子商户id
        /// </summary>
        public string SubMchId { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/mch_query/qpay_hb_mch_list_query.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "send_type", SendType },
                { "mch_billno", MchBillNo },
                { "listid", ListId },
                { "sub_mch_id", SubMchId },
            };
            return parameters;
        }

        public void PrimaryHandler(QPayOptions options, QPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(QPayConsts.NONCE_STR, QPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(QPayConsts.MCH_ID, options.MchId);

            sortedTxtParams.Add(QPayConsts.SIGN, QPaySignature.SignWithKey(sortedTxtParams, options.Key));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
