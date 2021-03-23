using ECDFind.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ECDFind.ViewModels
{

 
    public class ECDList_ViewModel
    {
        public ObservableCollection<ECDListModel> ECDList { get; set; }

        public ECDList_ViewModel()
        {
            ECDList = new ObservableCollection<ECDListModel>();
            ECDList.Add(new ECDListModel { ECDName = "Test1", ECDEmail = "ECD@123.com", ECDCost = "R150pm", ECDDetails = "this is a dummy ECD", ECDNumber = "021 374 6832" });
        }

    }
}
