using System;
using System.Web.UI;
using AlterianEMAPI_WebForm.BizLogic;

namespace AlterianEMAPI_WebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            todo:// login process is not implemented
            var emList = new EMList();
            emList.Download();
        }
    }
}