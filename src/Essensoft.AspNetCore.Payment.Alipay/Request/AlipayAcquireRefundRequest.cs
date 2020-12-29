using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.acquire.refund
    /// </summary>
    public class AlipayAcquireRefundRequest : IAlipayRequest<AlipayAcquireRefundResponse>
    {
        /// <summary>
        /// 卖家的操作员ID。
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员的类型：  0：支付宝操作员  1：商户的操作员  如果传入其它值或者为空，则默认设置为1。
        /// </summary>
        public string OperatorType { get; set; }

        /// <summary>
        /// 商户退款请求单号，用以标识本次交易的退款请求。  如果不传入本参数，则以out_trade_no填充本参数的值。同时，认为本次请求为全额退款，要求退款金额和交易支付金额一致。
        /// </summary>
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 业务关联ID集合，用于放置商户的退款单号、退款流水号等信息，json格式
        /// </summary>
        public string RefIds { get; set; }

        /// <summary>
        /// 退款金额；退款金额不能大于订单金额，全额退款必须与订单金额一致。
        /// </summary>
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因说明。
        /// </summary>
        public string RefundReason { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。  最短16位，最长64位。  如果同时传了out_trade_no和trade_no，则以trade_no为准
        /// </summary>
        public string TradeNo { get; set; }

        #region IAlipayRequest Members
        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.acquire.refund";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "operator_id", OperatorId },
                { "operator_type", OperatorType },
                { "out_request_no", OutRequestNo },
                { "out_trade_no", OutTradeNo },
                { "ref_ids", RefIds },
                { "refund_amount", RefundAmount },
                { "refund_reason", RefundReason },
                { "trade_no", TradeNo }
            };
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
