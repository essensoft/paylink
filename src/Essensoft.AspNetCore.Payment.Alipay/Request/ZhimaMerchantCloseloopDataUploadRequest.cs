using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// zhima.merchant.closeloop.data.upload
    /// </summary>
    public class ZhimaMerchantCloseloopDataUploadRequest : IAlipayUploadRequest<ZhimaMerchantCloseloopDataUploadResponse>
    {
        /// <summary>
        /// 公用回传参数（非必填），该参数会透传给商户，商户可以用于业务逻辑处理，请使用json格式。
        /// </summary>
        public string BizExtParams { get; set; }

        /// <summary>
        /// 单条数据的数据列，多个列以逗号隔开。
        /// </summary>
        public string Columns { get; set; }

        /// <summary>
        /// 传入的json格式的文件，其中records属性必填。json中的字段可以通过如下步骤获取：首先调用zhima.merchant.data.upload.initialize接口获取数据模板，该接口会返回一个数据模板文件的url地址，如：http://zmxymerchant-prod.oss-cn-shenzhen.zmxy.com.cn/openApi/openDoc/信用护航-负面记录和信用足迹商户数据模板V1.0.xlsx，该数据模板文件详细列出了需要传入的字段，及各字段的要求，data中的各字段就是该文件中列出的字段编码。
        /// </summary>
        public FileItem File { get; set; }

        /// <summary>
        /// 文件的编码，如果文件格式是UTF-8，则填写UTF-8，如果文件格式是GBK，则填写GBK。
        /// </summary>
        public string FileCharset { get; set; }

        /// <summary>
        /// 芝麻平台服务商模式下的二级商户标识（即二级商户PID），如果是直连商户调用该接口，不需要设置
        /// </summary>
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 主键列使用传入字段进行组合，也可以使用传入的某个单字段（确保主键稳定，而且可以很好的区分不同的数据）。例如order_no,pay_month或者order_no,bill_month组合，对于一个order_no只会有一条数据的情况，直接使用order_no作为主键列。
        /// </summary>
        public string PrimaryKeyColumns { get; set; }

        /// <summary>
        /// 文件数据记录条数，如file字段中的record数组有10条数据，那么就填10。
        /// </summary>
        public string Records { get; set; }

        /// <summary>
        /// 数据应用的场景编码，场景码和场景名称（数字或字符串为场景码）如下：  8：数据反馈  32：骑行  CAR_RENTING：租车行业解决方案  每个场景码对应的数据模板不一样，请使用zhima.merchant.data.upload.initialize接口获取场景码对应的数据模板。
        /// </summary>
        public string SceneCode { get; set; }

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
            return "zhima.merchant.closeloop.data.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "biz_ext_params", BizExtParams },
                { "columns", Columns },
                { "file_charset", FileCharset },
                { "linked_merchant_id", LinkedMerchantId },
                { "primary_key_columns", PrimaryKeyColumns },
                { "records", Records },
                { "scene_code", SceneCode }
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
                { "file", File }
            };
            return parameters;
        }

        #endregion
    }
}
