using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.ins.scene.insserviceprod.serattachment.upload
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerattachmentUploadRequest : IAlipayUploadRequest<AlipayInsSceneInsserviceprodSerattachmentUploadResponse>
    {
        /// <summary>
        /// 扩展信息，JSON字符串格式。该接口为通用接口，需要和增值服务中台的开发同学根据不同的业务约定不同的字段。
        /// </summary>
        public string BizData { get; set; }

        /// <summary>
        /// 文件业务码(业务方自定义)
        /// </summary>
        public string FileBizCode { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文件描述
        /// </summary>
        public string FileDesc { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 文件大小，对应java里面File的length
        /// </summary>
        public string FileSize { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务单据号
        /// </summary>
        public string SerBizNo { get; set; }

        /// <summary>
        /// 服务业务类型
        /// </summary>
        public string SerBizType { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public Nullable<DateTime> UploadTime { get; set; }

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
            return "alipay.ins.scene.insserviceprod.serattachment.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "biz_data", BizData },
                { "file_biz_code", FileBizCode },
                { "file_desc", FileDesc },
                { "file_name", FileName },
                { "file_path", FilePath },
                { "file_size", FileSize },
                { "file_type", FileType },
                { "out_biz_no", OutBizNo },
                { "ser_biz_no", SerBizNo },
                { "ser_biz_type", SerBizType },
                { "upload_time", UploadTime }
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
                { "file_content", FileContent }
            };
            return parameters;
        }

        #endregion
    }
}
