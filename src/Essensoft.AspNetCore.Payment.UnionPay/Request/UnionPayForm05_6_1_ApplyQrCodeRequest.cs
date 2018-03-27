using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.UnionPay.Response;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 申请二维码（主扫）
    /// </summary>
    public class UnionPayForm05_6_1_ApplyQrCodeRequest : IUnionPayRequest<UnionPayForm05_6_1_ApplyQrCodeResponse>
    {
        /// <summary>
        /// 订单发送时间
        /// 商户发送交易时间
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 后台通知地址
        /// 支付结果将送到本地址
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// 交易币种
        /// 默认为156
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 商户订单号
        /// 商户端生成 交易子类为申请收款二维码时，仅表示申请二维码的订单号，可供后续撤销二维码用；交易子类为申请订单二维码时，表示申请二维码和一笔真实订单的订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 终端信息
        /// </summary>
        public string TermInfo { get; set; }

        /// <summary>
        /// 二级商户代码
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string SubMerId { get; set; }

        /// <summary>
        /// 二级商户简称
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string SubMerAbbr { get; set; }

        /// <summary>
        /// 二级商户名称
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string SubMerName { get; set; }

        /// <summary>
        /// 分账域
        /// </summary>
        public string AccSplitData { get; set; }

        /// <summary>
        /// 接入机构代码
        /// 接入机构接入时必送
        /// </summary>
        public string AccInsCode { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 交易金额
        /// 若不出现，需要对方输入金额
        /// </summary>
        public string TxnAmt { get; set; }

        /// <summary>
        /// 控制规则
        /// 32位01字符串控制位，从左至右第二位取值为1时表示小微商户
        /// </summary>
        public string CtrlRule { get; set; }

        /// <summary>
        /// 请求方保留域
        /// 商户自定义保留域，交易应答时会原样返回
        /// </summary>
        public string ReqReserved { get; set; }

        /// <summary>
        /// 支付超时时间
        /// 主扫申码的时候，表示二维码本身的有效时间，商户未上送默认填1天，商户上送了则取商户上送的，最大有效时间1个月
        /// </summary>
        public string PayTimeout { get; set; }

        /// <summary>
        /// 终端号
        /// 原则是可以通过交易上送的终端编号准确定位商户每一个门店内每一台收银设备，建议按“门店编号+收银机编号”或“设备编号”组成8位终端编号在交易中上送。商户需将终端编号与门店对应关系反馈给银联。
        /// </summary>
        public string TermId { get; set; }

        #region IUnionPayRequest
        private string version = string.Empty;
        private string txnType = "01";
        private string txnSubType = "07";
        private string bizType = "000000";
        private string channelType = "08";

        public string GetApiVersion()
        {
            return version;
        }

        public void SetApiVersion(string version)
        {
            this.version = version;
        }

        public string GetTxnType()
        {
            return txnType;
        }

        public void SetTxnType(string txnType)
        {
            this.txnType = txnType;
        }

        public string GetTxnSubType()
        {
            return txnSubType;
        }

        public void SetTxnSubType(string txnSubType)
        {
            this.txnSubType = txnSubType;
        }

        public string GetBizType()
        {
            return bizType;
        }

        public void SetBizType(string bizType)
        {
            this.bizType = bizType;
        }

        public string GetChannelType()
        {
            return channelType;
        }

        public void SetChannelType(string channelType)
        {
            this.channelType = channelType;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new UnionPayDictionary
            {
                { "txnTime", TxnTime },
                { "backUrl", BackUrl },
                { "currencyCode", CurrencyCode },
                { "orderId", OrderId },
                { "termInfo", TermInfo },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "accSplitData", AccSplitData },
                { "accInsCode", AccInsCode },
                { "reserved", Reserved },
                { "txnAmt", TxnAmt },
                { "ctrlRule", CtrlRule },
                { "reqReserved", ReqReserved },
                { "payTimeout", PayTimeout },
                { "termId", TermId },
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://gateway.test.95516.com/gateway/api/backTransReq.do" : "https://gateway.95516.com/gateway/api/backTransReq.do";
        }

        #endregion
    }
}
