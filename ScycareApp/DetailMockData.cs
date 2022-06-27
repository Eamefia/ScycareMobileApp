using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScycareApp
{
    public class DetailMockData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<DetailsModel> DetailsModels;

        public ObservableCollection<DetailsModel> details
        {
            get { return DetailsModels; }
            set
            {
                DetailsModels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("details"));
            }
        }

        public DetailMockData()
        {
            details = new ObservableCollection<DetailsModel>();
            addData();
        }

        private void addData()
        {
            details.Add(new DetailsModel
            {
                ItemName = "Sample Required",
                Item = "Blood",
                ImageUrl = "sampletube.png"
            });
            details.Add(new DetailsModel
            {
                ItemName = "Fasting Period",
                Item = "8-12 Hours",
                ImageUrl = "fasting.png"
            });
            details.Add(new DetailsModel
            {
                ItemName = "Other requirement",
                Item = "Preferable in the morning",
                ImageUrl = "medicalreport.png"
            });
            details.Add(new DetailsModel
            {
                ItemName = "Hours/Days for Results ",
                Item = "12 to 48 Hours",
                ImageUrl = "testduration.png"
            });
            details.Add(new DetailsModel
            {
                ItemName = "Test Type",
                Item = "single",
                ImageUrl = "testtube.png"
            });
        }
    }
}
