﻿
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }    //Marka
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }  //Gunluk fiyati
        public string Description { get; set; } //Aciklama
        public int MinFindexScore { get; set; }

    }
}
