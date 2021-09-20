using ContactsApp.Model;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace ContactsApp.ViewModel
{
   public class ContactsViewModel : BaseViewModel
    {
        private string url = "https://randomuser.me/api/?results=50";
        private HttpClient cliente = new HttpClient();

        public ObservableCollection<Result> Data { get; set; }

        public ContactsViewModel()
        {
            Data = new ObservableCollection<Result>();
            LoadUsers();
        }
        private async void LoadUsers()
        {
            var json = await cliente.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<JsonDataModel>(json);

            foreach (var i in data.Results)
            {
                Data.Add(i);
            }
        }
    }
}
