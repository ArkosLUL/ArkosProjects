﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kas_csharp_lr_2._1
{
    public class Article
    {
        public string Article_name
        {get; set;}
        public int Quantity_of_sings
        {get; set;}
        public DateTime Date_of_publishing
        {get;set;}
        public Article(string article_name, int quantity_of_sings, DateTime date_of_publishing)
        {
            this.Article_name = article_name;
            this.Quantity_of_sings = quantity_of_sings;
            this.Date_of_publishing = date_of_publishing;
        }
        public Article()
        {
                this.Article_name = "blank";
                this.Quantity_of_sings = 0;
                this.Date_of_publishing = DateTime.Today;
        }
        public override string ToString()
        {
            return String.Format("Article name: "+ Article_name + " Quantity of sings in article: " + Quantity_of_sings + " Date of article publishing: " + Date_of_publishing+"\n");
        }
    }
}
    public enum Level
    {
        Junior,
        MidLevel,
        Professor
    }
