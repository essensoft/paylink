using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.ebpp.prodmode.agreement.upload
    /// </summary>
    public class AlipayEbppProdmodeAgreementUploadRequest : IAlipayUploadRequest<AlipayEbppProdmodeAgreementUploadResponse>
    {
        /// <summary>
        /// 操作者名称
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 创建批次任务ID，生成结果需要外部商户邦道提交批次水燃入驻信息，调用alipay.ebpp.isv.prodmode.create入驻信息开放接口，缴费端接收请求，创建批次任务，生成任务ID，通过创建任务接口返回给邦道。
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// byte[]数组类型值，提供邦道授权函协议上传，上传文件格式必须是.rar或.zip压缩文件。
        /// </summary>
        public FileItem UploadFile { get; set; }

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
            return "alipay.ebpp.prodmode.agreement.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "operator_name", OperatorName },
                { "task_id", TaskId }
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
                { "upload_file", UploadFile }
            };
            return parameters;
        }

        #endregion
    }
}
