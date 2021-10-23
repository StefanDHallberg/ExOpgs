﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        public int MyProperty { get; set; }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Book(string itemId, string title, double price) : this(itemId)
        {
            base.ItemId = itemId;
               // itemId = itemId;
            this.title = title;
            this.price = price;
        }
        public Book(string itemId, string title) : this(itemId)
        {
            base.ItemId = itemId;
            this.title = title;
        }
        public Book(string itemId)

        {
            base.ItemId = itemId;
        }
        public override string ToString() //Ctrl + k+c = comment -> ctrl + k + u = Uncomment
        {
            return $"ItemId: {ItemId}, Title: {title}, Price: {price}";
        }

    }
}
