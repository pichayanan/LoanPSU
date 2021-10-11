using BlazorApp.Models;
using BlazorApp.ModelsDB;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class CheckDataByApplyLoan
    {
        private LoanType loanData;
        private ApplyLoanModel info;
        private List<UploadModel> FileUpload;
        private String LoanInterate { get; set; } = " ไม่มี";
        private string TypeInterate { get; set; } = "%";
        public const string IMG_DIR = "images";
        [Inject] IWebHostEnvironment env { get; set; }

        protected async override Task OnInitializedAsync()
        {
            loanData = new LoanType();
            info = new ApplyLoanModel();
            FileUpload = new List<UploadModel>();
            var checkData = await sessionStorage.GetItemAsStringAsync("FromLoan_1");
            var checkUploadImg = await sessionStorage.GetItemAsStringAsync("FromLoan_2");
            if (checkData != null)
            {
                info = await sessionStorage.GetItemAsync<ApplyLoanModel>("FromLoan_1");
                loanData = _context.LoanTypes.Where(c => c.LoanTypeId == info.LoanTypeID).FirstOrDefault();
                if (loanData == null)
                {
                /*กลับไปยังหน้าหลัง เนื่องจากไม่พบประเภทการกู้นั้นๆ */
                }
            }
            else
            {
            /*Error ไม่มีตัว FromLoan_1 */
            /*  info.LoanTypeID = 0;
                info.LoanMaxAmount = 0;
                info.Period = 0;
                info.Guarantor = "null"; */
            }
            if(checkUploadImg != null)
            {
                FileUpload = await sessionStorage.GetItemAsync<List<UploadModel>>("FromLoan_2");
                Console.WriteLine(FileUpload);
            }
            else
            {

            }
        }

        public void BackPage()
        {
            NavigationManager.NavigateTo("/uploaddoc");
        }

        public void NextPage()
        {
            if(FileUpload.Count != 0)
            {
                SaveToFolderImages();
            }
            NavigationManager.NavigateTo("/applyloansuccess");
        }

        public void SaveToFolderImages()
        {
            var dirToSave = Path.Combine(env.WebRootPath, IMG_DIR);
            var di = new DirectoryInfo(dirToSave);
            if (!di.Exists)
            {
                di.Create();
            }
            for (var i=0; i < FileUpload.Count; i++)
            {
                var ele = FileUpload[i];
                var fileName = ele.TempImgName;
                var path_To = ele.Url;

                var filePath_From = Path.Combine(dirToSave, fileName);
                File.Move(path_To, filePath_From);
            }
        }


    }
}
