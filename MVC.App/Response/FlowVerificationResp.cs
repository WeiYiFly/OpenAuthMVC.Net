using MVC.Repository.Domain;

namespace MVC.App.Response
{
    public class FlowVerificationResp :FlowInstance
    {
        /// <summary>
        /// 预览表单数据
        /// </summary>
        /// <value>The FRM data HTML.</value>
        public string FrmPreviewHtml
        {
            get { return FormUtil.Preview(FrmContentData, FrmContentParse, FrmData); }
        }
    }
}
