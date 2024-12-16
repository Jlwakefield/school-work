using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using vechicals.Resources.modles;

namespace vechicals.Resources.viewmodles
{
    public partial class vehical_vm : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<vehicle> vehicals;
        private string _samplePictureUrl;

        public vehical_vm()
        {
            this._samplePictureUrl = "dotet_bot.png";
            this.vehicals = new ObservableCollection<vehicle>();
            AddSampleData();
        }


        void AddSampleData()
        {
            Vehicals.Add(new vehicle("Ford", "fiesta", _samplePictureUrl));
            Vehicals.Add(new vehicle("Ford", "focous", _samplePictureUrl));
            Vehicals.Add(new vehicle("Ford", "mustang", _samplePictureUrl));
            Vehicals.Add(new vehicle("Chevrolet", "Camro", _samplePictureUrl));
            Vehicals.Add(new vehicle("Chaevrolet", "Corvette", _samplePictureUrl));
            Vehicals.Add(new vehicle("Dodge", "Challenger", _samplePictureUrl));
            ;


        }
    }
}
