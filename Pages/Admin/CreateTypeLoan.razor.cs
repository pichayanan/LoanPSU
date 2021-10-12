using BlazorApp.Data;
using BlazorApp.Models;
using BlazorApp.ModelsDB;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages.Admin
{
    public partial class CreateTypeLoan
    {
        List<TypeLoan> ListType;
        TypeLoan Loan;
        UploadModel ModelUpload;
        public Boolean changType { get; set; } = false;
        public const string LOANDOC_DIR = "loanDoc";
        [Inject] IWebHostEnvironment env { get; set; }

        protected override void OnInitialized()
        {
            ModelUpload = new UploadModel();
            ListType = new List<TypeLoan>();
            Loan = new TypeLoan();
            ListType = _context.TypeLoans.ToList<TypeLoan>();
        }

        public void SetCurrentData(DTEventArgs value)
        {
            ModelUpload.Name = value.Params[0].ToString();
            ModelUpload.Url = value.Params[1].ToString();
            ModelUpload.TempImgName = value.Params[2].ToString();
        }

        public void BackPage()
        {
            NavigationManager.NavigateTo("./Admin/ManageTypeLoan");
        }

        public void ToggleButton(Boolean toggle)
        {
            changType = toggle;
        }

        public void SelectType(Boolean toggle, TypeLoan loantype)
        {
            Loan.LoanParentName = loantype.LoanParentName;
            ToggleButton(toggle);
        }

        public void SaveToDb()
        {
            Console.WriteLine(Loan);

            MoveFile();
            
        /*    Loan.Active = 1;
            _context.TypeLoans.Add(Loan);
            await _context.SaveChangesAsync();*/
        }

        public void MoveFile()
        {
            var dirToSave = Path.Combine(env.WebRootPath, LOANDOC_DIR);
            var di = new DirectoryInfo(dirToSave);
            if (!di.Exists)
            {
                di.Create();
            }
            var fileName = ModelUpload.TempImgName;
            var path_To = ModelUpload.Url;
            var filePath_From = Path.Combine(dirToSave, fileName);
            File.Move(path_To, filePath_From);
            /* Add data*/
            Loan.PathFile = filePath_From;
            Loan.FileName = ModelUpload.Name;
        }
    }
}
