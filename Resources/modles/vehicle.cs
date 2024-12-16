using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vechicals.Resources.modles
{
    public partial class vehicle : ObservableObject
    {
        [ObservableProperty]
        private Guid id;


        [ObservableProperty]
        public string make;

        [ObservableProperty]
        public string moldle;

        [ObservableProperty]
        public string url;

        public virtual void truckHorn()
        {
            //car beeps horn 
            //truck honks horn
        } 
        public vehicle(string make , string modle, string url)
        {
           this.Id = Guid.NewGuid();
           this.Make = make;
           this.Moldle = modle;
           this.Url = url;
        }


    }
}
