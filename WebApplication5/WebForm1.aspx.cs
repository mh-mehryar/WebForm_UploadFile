using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_UploadFile
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpBtn_Click(object sender, EventArgs e)
        {
            LabMsg.Text = string.Empty;
            if (!UpFile.HasFile)
            {
                LabMsg.Text = "لطفا فایل عکس خود را انتخاب نمائید";
                return;
            }
            string[] ValidExtensions = { ".jpg", ".png", ".bmp",".gif" };
            string FileExtension = System.IO.Path.GetExtension(UpFile.FileName);
            if (ValidExtensions.Contains(FileExtension))
            {
                double FileSize = (UpFile.PostedFile.ContentLength) / 1024.0;
                if (FileSize > 500 )
                {
                    LabMsg.Text = "اندازه فایل عکس شما بیشتر از 500 کیلوبایت می باشد";
                    return;
                }
                string StrServerPath = Server.MapPath("");
                StrServerPath += "/UserFiles/Images/" + UpFile.FileName;
                UpFile.SaveAs(StrServerPath);
                
            }
            else
            {
                LabMsg.Text = "لطفا نوع فایل خود را درست انتخاب نمائید";
                return;
            }
        }
    }
}