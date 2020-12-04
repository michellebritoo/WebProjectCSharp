﻿using System;
using BritoWebMVC.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BritoWebMVC.Models
{
    public class SallesRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString= "{0: dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0: F2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SallesRecord()
        {

        }

        public SallesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
