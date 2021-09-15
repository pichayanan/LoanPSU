using BlazorApp.Data;
using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class UploadDoc
    {
        UploadModel ModelUpload;
        List<UploadModel> resultInfoList;
        UploadModel SelectListUpload;
        [Inject] Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            resultInfoList = new List<UploadModel>();
        }

        public void SetCurrentData(DTEventArgs value)
        {
            ModelUpload = new UploadModel();
            ModelUpload.Id = resultInfoList.Count() + 1;
            ModelUpload.Name = value.Params[0].ToString();
            ModelUpload.Url = value.Params[1].ToString();
            resultInfoList.Add(ModelUpload);
        }

        public void ConfirmFrom(UploadModel listUpload)
        {
            SelectListUpload = new UploadModel();
            SelectListUpload = listUpload;
        }

        public void DeleteFile()
        {
            if (SelectListUpload != null)
            {
                if (CheckFileExist(SelectListUpload.Url))
                {
                    var myTodo = resultInfoList.FirstOrDefault(x => x.Id == SelectListUpload.Id);
                    resultInfoList.Remove(myTodo);
                    File.Delete(SelectListUpload.Url);
                }
            }
        }

        protected bool CheckFileExist(string URL)
        {
            bool RetFlag = false;
            RetFlag = File.Exists(URL);
            return RetFlag;
        }

        async Task NextPage()
        {
            await SaveDataToStorage("FromLoan_2", resultInfoList);
            NavigationManager.NavigateTo("/CheckDataByApplyLoan");
        }
        public void BackPage()
        {
            if (resultInfoList.Count != 0)
            {
                for (var i = 0; i < resultInfoList.Count; i++)
                {
                    var element = resultInfoList[i];
                    if (CheckFileExist(element.Url))
                    {
                        File.Delete(element.Url);
                    }
                }
            }
            NavigationManager.NavigateTo("/applyloan");
        }
        async Task SaveDataToStorage(string key, List<UploadModel> val = null)
        {
            if (val != null) {
            await sessionStorage.SetItemAsync(key, val);
            Console.WriteLine("result");
            }
        }

    }
}
