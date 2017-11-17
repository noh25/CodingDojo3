using GalaSoft.MvvmLight;
using Shared.BaseModels;
using Shared.Models;

namespace CodingDojo3_Hava.ViewModel
{
    public class ItemVm : ViewModelBase

    { 
        private ItemBase baseItem;

        public int Id
        {
            get { return this.Id; }
            //set;
        }
        public string Description
        {
            get { return this.Description; }
            set { this.Description = value; RaisePropertyChanged(); }
        }
        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; RaisePropertyChanged(); }
        }
        public string Room
        {
            get { return this.Room; }
            set { this.Room = value; RaisePropertyChanged(); }
        }
        public int PosX
        {
            get { return this.PosX; }
            set { this.PosX = value; RaisePropertyChanged(); }
        }
        public int PosY
        {
            get { return this.PosY; }
            set { this.PosY = value; RaisePropertyChanged(); }
        }
        public string ValueType
        {
            get { return myVar; }
            
        }


    }
}