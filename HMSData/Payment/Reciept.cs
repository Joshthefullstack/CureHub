using HMSData.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.Payment
{
    public class Reciept
    {
        public string RecieptId { get; set; }
        public int s_ReceiptId = 1234;
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string Narration {  get; set; }
        public int TotalAmount { get; set; }

        public Reciept() 
        {
        }

        public string InitReceipt(PaymentMethod paymentMethod, PaymentStatus paymentStatus, string narration, int totalAmount)
        {
            RecieptId = s_ReceiptId.ToString();
            s_ReceiptId++;
            PaymentMethod = paymentMethod;
            PaymentStatus = paymentStatus;
            Narration = narration;
            TotalAmount = totalAmount;

            if(RecieptId.Length > 0)
            {
                return RecieptId;
            }

            return "";
        }

        //public string PaymentReceipt(PaymentMethod paymentMethod, PaymentStatus paymentStatus, string narration, int totalAmount)
        //{
        //    RecieptId = s_ReceiptId.ToString();
        //    s_ReceiptId++;
        //    PaymentMethod = paymentMethod;
        //    PaymentStatus = paymentStatus;
        //    Narration = narration;
        //    TotalAmount = totalAmount;

        //    return RecieptId;
        //}
    }
}
