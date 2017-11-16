using System;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3_Hava.ViewModel
{
    class Actuators : ViewModelBase
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Room { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string ValueType { get; set; }
        public string ItemType { get; set; }
        public string Mode { get; set; }
        public int Value { get; set; }
        private bool isInDesignMode;
        public bool IsInDesignMode
        {
            get { return isInDesignMode; }
            set { isInDesignMode = value; RaisePropertyChanged(); }
        }

        public Actuators(int id, string description, string name, string room, int posX, int posY, string valueType, string itemType, string mode, int value, bool isInDesignMode)
        {
            Id = id;
            Description = description;
            Name = name;
            Room = room;
            PosX = posX;
            PosY = posY;
            ValueType = valueType;
            ItemType = itemType;
            Mode = mode;
            Value = value;
            IsInDesignMode = isInDesignMode;
        }
    }
}
