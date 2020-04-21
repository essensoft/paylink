using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.pcredit.loan.collateral.operation.sync
    /// </summary>
    public class AlipayPcreditLoanCollateralOperationSyncRequest : IAlipayUploadRequest<AlipayPcreditLoanCollateralOperationSyncResponse>
    {
        /// <summary>
        /// 业务流水号，即用户授信申请的单号，每次授信申请由借呗平台生成的唯一编号，通知估值时给到机构
        /// </summary>
        public string ApplyNo { get; set; }

        /// <summary>
        /// 上传附件的二进制流，最大限10M，以下操作类型时必填写：  UPLOAD_REC：上传抵押回执照片  UPLOAD_REG：上传抵押登记证照片
        /// </summary>
        public FileItem Attachment { get; set; }

        /// <summary>
        /// JSON格式的业务扩展信息，具体操作和机构约定具体的扩展信息
        /// </summary>
        public string BizExtInfo { get; set; }

        /// <summary>
        /// 操作备注，备注信息越详实越好
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 操作时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string OperatedTime { get; set; }

        /// <summary>
        /// 操作类型，目前对押品约定的操作有：  PLEDGED：已入押  UNPLEDGED：已出押；  DISPOSING：处置中；  DISPOSED：已处置；  VERIFIED：已核实；  REJECTED：核实拒绝；  UPLOAD_REC：上传抵押回执（receipt）照片  UPLOAD_REG：上传抵押登记证（registration certificate）照片
        /// </summary>
        public string OperatedType { get; set; }

        /// <summary>
        /// 操作人姓名
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 机构请求流水号，请求的幂等字段，作为业务幂等性控制
        /// </summary>
        public string OutRequestNo { get; set; }

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

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.pcredit.loan.collateral.operation.sync";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "apply_no", ApplyNo },
                { "biz_ext_info", BizExtInfo },
                { "memo", Memo },
                { "operated_time", OperatedTime },
                { "operated_type", OperatedType },
                { "operator", Operator },
                { "out_request_no", OutRequestNo }
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "attachment", Attachment }
            };
            return parameters;
        }

        #endregion
    }
}
