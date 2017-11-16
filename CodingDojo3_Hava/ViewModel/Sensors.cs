using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3_Hava.ViewModel
{
    class Sensors : ViewModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public string Mode { get; set; }
        public string ValueType { get; set; }
        public int Value { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Sensors(int id, string name, string description, string room, string mode, string valueType, int value, int posX, int posY)
        {
            Id = id;
            Name = name;
            Description = description;
            Room = room;
            Mode = mode;
            ValueType = valueType;
            Value = value;
            PosX = posX;
            PosY = posY;
        }
    }
}
